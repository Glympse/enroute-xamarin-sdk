
namespace Glympse
{
    public interface GLocation : GLatLng
    {
        long getTime();

        float getVAccuracy();

        float getHAccuracy();

        float getSpeed();

        float getBearing();

        float getAltitude();
    }
}
