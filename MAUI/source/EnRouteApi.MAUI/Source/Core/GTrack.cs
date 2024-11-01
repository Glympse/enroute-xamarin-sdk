namespace Glympse
{
    public interface GTrack : GCommon
    {
        int length();

        int getDistance();

        GList<GLocation> getLocations();

        GList<GLocation> getNewLocations();
    }
}
