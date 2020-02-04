using System.Collections.Generic;

namespace Graphene.SharedModels.Network
{
    public class NetworkClient
    {
        public readonly string userName;
        private readonly List<string> connectionId;

        private bool _changed;

        public bool IsDirty => _changed;

        private int _selectedCharacter;
        public int SelectedCharacter => _selectedCharacter;

        public NetworkClient(string userName, List<string> connectionId)
        {
            this.userName = userName;
            this.connectionId = connectionId;
        }

        public int Count => connectionId.Count;

        public void Remove(string id)
        {
            connectionId.Remove(id);
        }

        public void Add(string id)
        {
            connectionId.Add(id);
        }

        public void SelectCharacter(int id)
        {
            _selectedCharacter = id;
            _changed = true;
        }

        public void Update(NetworkClient client)
        {
            _selectedCharacter = client._selectedCharacter;

            for (int i = 0; i < client.connectionId.Count; i++)
            {
                if (connectionId.Count <= i)
                {
                    connectionId.Add(client.connectionId[i]);
                    continue;
                }

                connectionId[i] = client.connectionId[i];
            }

            _changed = false;
        }
    }
}