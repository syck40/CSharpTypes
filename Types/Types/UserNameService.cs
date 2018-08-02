using System;

namespace Game.Core
{
    internal class UserNameService
    {
        public UserNameService()
        {
        }

        internal string LowerName(string name)
        {
            return name.ToLower();
        }
    }
}