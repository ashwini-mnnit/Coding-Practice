using System.Collections.Generic;

public class LRUCache<K, V> {
    private int size;
    private LinkedList<Node<K, V>> list;

    // Key- HashCode of T
    private Dictionary<K, Node<K, V>> map;

    public LRUCache (int size) {
        this.list = new LinkedList<Node<K, V>> ();
        this.map = new Dictionary<K, Node<K, V>> ();
        this.size = size;
    }
    public void Add (K key, V val) {
        if (this.list.Count == this.size) {
            // Remove LRU
            Node<K, V> lastNode = this.list.Last.Value;
            this.list.RemoveLast ();
            this.map.Remove (lastNode.key);
        }

        Node<K, V> node = new Node<K, V> (key, val);
        this.list.AddFirst (node);
        this.map.Add (key, node);
    }

    // TODO: Define indexer
    public V Get (K key) {
        if (!this.map.ContainsKey (key)) {
            throw new System.Exception ($"Key {key} does not exist");
        }

        Node<K, V> val = this.map[key];

        // Remove
        this.map.Remove (key);
        this.list.Remove (val);

        // Add First
        this.list.AddFirst (val);
        this.map.Add (key, val);

        return this.map[key].val;
    }

    public void Remove (K key) {
        Node<K, V> node = this.map[key];
        this.list.Remove (node);
        this.map.Remove (key);
    }

    public bool ContainsKey (K key) {
        return this.map.ContainsKey (key);
    }
}