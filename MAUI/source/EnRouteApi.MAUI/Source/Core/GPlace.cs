using System;
namespace Glympse
{
    public interface GPlace : GCommon
    {
        string getName();

        double getLatitude();

        double getLongitude();
    }
}
