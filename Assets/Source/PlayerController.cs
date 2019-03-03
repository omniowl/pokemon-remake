using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Source
{
    public class PlayerController : GameController
    {
        PlayerController()
        {
            this.m_ControllerContext = ControllerContext.TRAVELING;
        }

        public override void ExecuteKeyPress(KeyCode key)
        {
            switch(key)
            {
                case KeyCode.W:
                case KeyCode.A:
                case KeyCode.D:
                case KeyCode.S:
                    Move(key);
                    break;
            }
        }

        private void Move(KeyCode key)
        {
            throw new NotImplementedException("Move is not implemented yet");
        }
    }
}
