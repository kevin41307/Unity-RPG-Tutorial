using UnityEngine;
using Zenject;

namespace Game.Scripts.Players.Datas
{
    [CreateAssetMenu(fileName = "PlayerCharacterDataContainer", menuName = "PlayerCharacterDataContainer", order = 0)]
    public class PlayerCharacterDataContainer : ScriptableObjectInstaller
    {
        [SerializeField]
        private float moveSpeed;

        public override void InstallBindings()
        {
            Container.Bind<float>().WithId("MoveSpeed").FromInstance(moveSpeed);
        }

    }
}