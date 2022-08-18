using System.Collections;
using Agate.MVC.Base;
using UnityEngine.InputSystem;
using SpaceInvader.Message;
using UnityEngine.EventSystems;
using UnityEngine;

namespace SpaceInvader.Module.Input
{
    public class InputController : BaseController<InputController>
    {

        private InputActionManager _inputActionsManager = new InputActionManager();

       
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _inputActionsManager.Game.Enable();
            _inputActionsManager.Game.Kanan.performed += kanan;
            _inputActionsManager.Game.Kiri.performed += kiri;
            _inputActionsManager.Game.Tembak.performed += tembak;
            _inputActionsManager.Game.Kanan.canceled += kanan;
            _inputActionsManager.Game.Kiri.canceled += kiri;
            _inputActionsManager.Game.Tembak.canceled += tembak;


        }



        public void OnGameOver(GameOverMessage message)
        {
            _inputActionsManager.Game.Disable();
        }


        private void kanan(InputAction.CallbackContext context)
        {
          
            bool isOverUI = EventSystem.current.IsPointerOverGameObject();
            if (context.performed && !isOverUI)
            {
                _inputActionsManager.Game.Kanan.Enable();
                Publish<PlayerMoveMessage>(new PlayerMoveMessage(1));

            }

            if (context.canceled && !isOverUI)
            {
                _inputActionsManager.Game.Kanan.Enable();
                Publish<PlayerMoveMessage>(new PlayerMoveMessage(0));

            }


        }

        private void kiri(InputAction.CallbackContext context)
        {
            bool isOverUI = EventSystem.current.IsPointerOverGameObject();
            if (context.performed && !isOverUI)
            {
                _inputActionsManager.Game.Kiri.Enable();
                Publish<PlayerMoveMessage>(new PlayerMoveMessage(-1));

            }

            if (context.canceled && !isOverUI)
            {
                _inputActionsManager.Game.Kiri.Enable();
                Publish<PlayerMoveMessage>(new PlayerMoveMessage(0));

            }

        }

        private void tembak(InputAction.CallbackContext context)
        {
            bool isOverUI = EventSystem.current.IsPointerOverGameObject();
            if (context.performed)
            {
                _inputActionsManager.Game.Tembak.Enable();
                Publish<StartPlayMessage>(new StartPlayMessage());
                Publish<PlayerShootMessage>(new PlayerShootMessage());
                Debug.Log("bamm");
                
            }
        }

        /* private void OnTap(InputAction.CallbackContext context)
         {
             bool isOverUI = EventSystem.current.IsPointerOverGameObject();
             if (context.performed && !isOverUI)
             {
                 Publish<MoveInsectMessage>(new MoveInsectMessage());
             }
         }*/
    }

}








