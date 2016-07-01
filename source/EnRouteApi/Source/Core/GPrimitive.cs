using System;

namespace Glympse
{
    public interface GPrimitive
    {
        /**
         * Common properties
         */

        object raw();

        int type();

        bool isArray();

        bool isObject();

        bool isDouble();

        bool isLong();

        bool isBool();

        bool isString();

        bool isNull();

        int size();
    
        GPrimitive clone();

        bool merge(GPrimitive from, bool overrideTarget);

        /**
         * Value getters
         */

        double getDouble();

        long getLong();

        bool getBool();

        string  getString();

        /**
         * Object getters
         */

        GPrimitive get(string key);

        double getDouble(string key);

        long getLong(string key);

        bool getBool(string key);

        string getString(string key);

        /*Enumeration<String> getKeys();*/

        bool hasKey(string key);

        /**
         * Array getters
         */

        GArray<GPrimitive> getArray();

        GPrimitive get(int index);

        double getDouble(int index);

        long getLong(int index);

        bool getBool(int index);

        string getString(int index);

        /**
         * Value modifiers
         */

        void set(double value);

        void set(long value);

        void set(bool value);

        void set(string value);

        void setNull();

        void setArray();

        void setObject();

        /**
         * Object modifiers
         */

        void put(string key, GPrimitive value);

        void put(string key, double value);

        void put(string key, long value);

        void put(string key, bool value);

        void put(string key, string value);

        void putNull(string key);

        void remove(string key);

        /**
         * Array modifiers.
         */

        void put(GPrimitive value);

        void put(double value);

        void put(long value);

        void put(bool value);

        void put(string value);

        void insert(int index, GPrimitive value);

        void put(int index, GPrimitive value);

        void put(int index, double value);

        void put(int index, long value);

        void put(int index, bool value);

        void put(int index, string value);

        void putNull(int index);

        void remove(int index);

        void remove(GPrimitive value);
    }
}
