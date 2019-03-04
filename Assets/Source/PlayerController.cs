using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace PR.Controllers
{
    public class PlayerController : GameController
    {
        public event EventHandler OnRequestMove;
        public event EventHandler OnRequestInteract;

        public PlayerController()
        {
            this.m_ControllerContext = ControllerContext.TRAVELING;
        }

        public override void ExecuteKeyPress(KeyCode key)
        {
            switch (key)
            {
                case KeyCode.W:
                case KeyCode.A:
                case KeyCode.D:
                case KeyCode.S:
                    Move(key);
                    break;
                case KeyCode.E:
                    Interact();
                    break;
            }
        }

        private void Move(KeyCode key)
        {
            if (OnRequestMove != null)
            {
                OnRequestMove(this, null);
            }
        }

        private void Interact()
        {

        }
    }
}
