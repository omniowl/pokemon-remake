using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PR.Controllers
{
    public abstract class GameController
    {
        public ControllerContext m_ControllerContext = ControllerContext.NONE;

        public virtual void ExecuteKeyPress(KeyCode key)
        {
            Debug.Log("ExecuteKeyPress() Not Implemented");
        }
    }
}