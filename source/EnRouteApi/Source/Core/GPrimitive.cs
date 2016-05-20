using System;

namespace Glympse
{
    public interface GPrimitive
    {
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

        /*bool merge(GPrimitive from, bool overrideTarget);*/

        double getDouble();

        long getLong();

        bool getBool();

        String getString();

        GPrimitive get(String key);

        double getDouble(String key);

        long getLong(String key);

        bool getBool(String key);

        String getString(String key);

        /*Enumeration<String> getKeys();*/

        bool hasKey(String key);
    }
}
