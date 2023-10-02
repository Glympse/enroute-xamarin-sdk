namespace Glympse
{
    namespace EnRoute
    {
        public interface GOperation : GCommon
        {
            int getState();   

            long getId();

            long getStartTime();

            string getTicketId();

            string getInviteUrl();

            string getInviteCode();

            long getTaskId();

            void setTicketEta(long eta);

            void setTicketVisible(string visible);
        }
    }
}
