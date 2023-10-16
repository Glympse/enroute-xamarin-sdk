namespace Glympse.EnRoute.iOS
{
    class ChatMessage : GChatMessage
    {
        private GlyChatMessage _raw;

        public ChatMessage(GlyChatMessage raw)
        {
            _raw = raw;
        }

        /**
         * GChatMessage section
         */

        public long getId()
        {
            return _raw.getId();
        }

        public long getCreatedTime()
        {
            return _raw.getCreatedTime();
        }

        public string getContents()
        {
            return _raw.getContents();
        }

        public string getAuthor()
        {
            return _raw.getAuthor();
        }

        public long getSequenceId()
        {
            return _raw.getSequenceId();
        }

        public bool isAgent()
        {
            return _raw.isAgent();
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}
