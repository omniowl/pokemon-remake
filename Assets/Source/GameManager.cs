using PR.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PR.Core
{
    public class GameManager : MonoBehaviour
    {
        private Dictionary<ControllerContext, GameController> controllers =
            new Dictionary<ControllerContext, GameController>();
        private ControllerContext m_CurrentControllerContext;

        public void Start()
        {
            controllers.Add(ControllerContext.TRAVELING, new PlayerController());
        }
    }
}