using System.Collections;
using System.Collections.Generic;

public class LFUCache<K, V> {
    private int size;
    private List<LinkedList<Node<K, V>> > list;

    // Key- HashCode of T
    private Dictionary<K, Node<K, V>> map;

    public LFUCache (int size) {
        this.list = new List<LinkedList<Node<K, V>> > ();
        this.map = new Dictionary<K, Node<K, V>> ();
        this.size = size;
    }
    public void Add (K key, V val) {
        if (this.map.Count == size) {
            // Remove LFU
            LinkedList<Node<K, V>> firstlist = this.list[0];
            Node<K, V> lastNode = firstlist.Last.Value;
            this.map.Remove (lastNode.key);
            firstlist.Remove (lastNode);
        }

        Node<K, V> node = new Node<K, V> (key, val);
        node.parentListId = 0;

        this.map.Add (key, node);
        if (this.list.Count == 0) {
            //Create FirstList
            LinkedList<Node<K, V>> firstlist = new LinkedList<Node<K, V>> ();
            firstlist.AddFirst (node);
        } else {
            this.list[0].AddFirst (node);
        }
    }

    // TODO: Define indexer
    public V Get (K key) {

        if (!this.map.ContainsKey (key)) {
            throw new KeyNotFoundException ("key does not exit in cache");
        }

        // move this
        Node<K, V> node = this.map[key];

        //Remove From currentList
        this.list[node.parentListId].Remove (node);
        this.map.Remove (key);
        if (this.list[node.parentListId].Count == 0) {
            //Cleanup
            this.list.RemoveAt (node.parentListId);
        }

        // move this to the next doublyList
        int listId = node.parentListId++;
        if (listId == this.list.Count - 1) {
            //Create a new List
            LinkedList<Node<K, V>> newList = new LinkedList<Node<K, V>> ();
            this.list.Add (newList);
        }

        LinkedList<Node<K, V>> doublyList = this.list[listId + 1];
        doublyList.AddFirst (node);
        this.map.Add (key, node);

        // return val
        return node.val;
    }

    public void Remove (K key) {
        Node<K, V> node = this.map[key];

        //Remove From currentList
        this.list[node.parentListId].Remove (node);
        this.map.Remove (key);
        if (this.list[node.parentListId].Count == 0) {
            //Cleanup
            this.list.RemoveAt (node.parentListId);
        }
    }

    public bool ContainsKey (K key) {
        return this.map.ContainsKey (key);
    }
}