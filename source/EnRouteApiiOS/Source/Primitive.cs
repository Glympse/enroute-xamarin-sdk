using System;

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

        /*public bool merge(com.glympse.android.core.GPrimitive from, bool overrideTarget)
        {
            return _raw.merge(from, overrideTarget);
        }*/

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

        public String getString()
        {
            return _raw.getString();
        }

        public GPrimitive get(String key)
        {
            return (GPrimitive) _raw.get(key);
        }

        public double getDouble(String key)
        {
            return _raw.getDouble(key);
        }

        public long getLong(String key)
        {
            return _raw.getLong(key);
        }

        public bool getBool(String key)
        {
            return _raw.getBool(key);
        }

        public String getString(String key)
        {
            return _raw.getString(key);
        }

        /*public Enumeration<String> getKeys()*/

        public bool hasKey(String key)
        {
            return _raw.hasKey(key);
        }
    }
}
