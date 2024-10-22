namespace Glympse.EnRoute.iOS
{
    class Primitive : GPrimitive
    {
        private GlyPrimitive _raw;

        public Primitive(GlyPrimitive raw)
        {
            _raw = raw;
        }

        public object raw()
        {
            return _raw;
        }

        public int type()
        {
            return _raw.type();
        }

        public bool isArray()
        {
            return _raw.isArray();
        }

        public bool isObject()
        {
            return _raw.isObject();
        }

        public bool isDouble()
        {
            return _raw.isDouble();
        }

        public bool isLong()
        {
            return _raw.isLong();
        }

        public bool isBool()
        {
            return _raw.isBool();
        }

        public bool isString()
        {
            return _raw.isString();
        }

        public bool isNull()
        {
            return _raw.isNull();
        }

        public int size()
        {
            return _raw.size();
        }

        public GPrimitive clone()
        {
            return (GPrimitive) _raw.clone();
        }

        public bool merge(GPrimitive from, bool overrideTarget)
        {
            return _raw.merge((GlyPrimitive) from.raw(), overrideTarget);
        }

        public double getDouble()
        {
            return _raw.getDouble();
        }

        public long getLong()
        {
            return _raw.getLong();
        }

        public bool getBool()
        {
            return _raw.getBool();
        }

        public string getString()
        {
            return _raw.getString();
        }

        public GPrimitive get(string key)
        {
            return (GPrimitive) _raw.get(key);
        }

        public double getDouble(string key)
        {
            return _raw.getDouble(key);
        }

        public long getLong(string key)
        {
            return _raw.getLong(key);
        }

        public bool getBool(string key)
        {
            return _raw.getBool(key);
        }

        public string getString(string key)
        {
            return _raw.getString(key);
        }

        /*public Enumeration<String> getKeys()*/

        public bool hasKey(string key)
        {
            return _raw.hasKey(key);
        }

        public GArray<GPrimitive> getArray()
        {
            return new Array<GPrimitive>(_raw.getArray());
        }

        public GPrimitive get(int index)
        {
            return (GPrimitive) _raw.get(index);
        }

        public double getDouble(int index)
        {
            return _raw.getDouble(index);
        }

        public long getLong(int index)
        {
            return _raw.getLong(index);
        }

        public bool getBool(int index)
        {
            return _raw.getBool(index);
        }

        public string getString(int index)
        {
            return _raw.getString(index);
        }

        public void set(double value)
        {
            _raw.set(value);
        }

        public void set(long value)
        {
            _raw.set(value);
        }

        public void set(bool value)
        {
            _raw.set(value);
        }

        public void set(string value)
        {
            _raw.set(value);
        }

        public void setNull()
        {
            _raw.setNull();
        }

        public void setArray()
        {
            _raw.setArray();
        }

        public void setObject()
        {
            _raw.setObject();
        }

        public void put(string key, GPrimitive value)
        {
            _raw.put(key, (GlyPrimitive) value.raw());
        }

        public void put(string key, double value)
        {
            _raw.put(key, value);
        }

        public void put(string key, long value)
        {
            _raw.put(key, value);
        }

        public void put(string key, bool value)
        {
            _raw.put(key, value);
        }

        public void put(string key, string value)
        {
            _raw.put(key, value);
        }

        public void putNull(string key)
        {
            _raw.putNull(key);
        }

        public void remove(string key)
        {
            _raw.remove(key);
        }

        public void put(GPrimitive value)
        {
            _raw.put((GlyPrimitive) value.raw());
        }

        public void put(double value)
        {
            _raw.put(value);
        }

        public void put(long value)
        {
            _raw.put(value);
        }

        public void put(bool value)
        {
            _raw.put(value);
        }

        public void put(string value)
        {
            _raw.put(value);
        }

        public void insert(int index, GPrimitive value)
        {
            _raw.insert(index, (GlyPrimitive) value.raw());
        }

        public void put(int index, GPrimitive value)
        {
            _raw.putWithInt(index, (GlyPrimitive) value.raw());
        }

        public void put(int index, double value)
        {
            _raw.put(index, value);
        }

        public void put(int index, long value)
        {
            _raw.put(index, value);
        }

        public void put(int index, bool value)
        {
            _raw.put(index, value);
        }

        public void put(int index, string value)
        {
            _raw.put(index, value);
        }

        public void putNull(int index)
        {
            _raw.putNull(index);
        }

        public void remove(int index)
        {
            _raw.remove(index);
        }

        public void remove(GPrimitive value)
        {
            _raw.remove((GlyPrimitive) value.raw());
        }
    }
}
