
using UnityEngine;
namespace Mobiiliesimerkki
{
    public interface IMover
    {
        float Speed { get; }

        void Move(Vector2 direction);
    }
}