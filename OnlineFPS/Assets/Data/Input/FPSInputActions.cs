//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Data/Input/FPSInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @FPSInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPSInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPSInputActions"",
    ""maps"": [
        {
            ""name"": ""DefaultMap"",
            ""id"": ""46bf95ba-b7a8-4da1-a4d5-ad49677d3765"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1b319d9c-b705-46f9-b440-deabe5108883"",
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookDelta"",
                    ""type"": ""Value"",
                    ""id"": ""9ac4461b-a0bd-43bc-9258-03bf2a17ca60"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LookConst"",
                    ""type"": ""Value"",
                    ""id"": ""847bdfb6-f46b-498d-b93b-4647302db5ac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""b58e7016-1fbe-440f-851d-fe5dc0b9bdf5"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""73c5ed6d-6e83-4693-857f-7a639b926770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""fe797924-662a-430c-adec-0ad8e35f90c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""025599b3-e820-4333-99db-6432435a6567"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""c67ae77d-ac15-40e3-8f93-54aae16763f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpectatorVertical"",
                    ""type"": ""Value"",
                    ""id"": ""40dffe79-c12a-4c22-8beb-c43868c3f55b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""57a3c129-4935-42e8-a713-862f74ef7291"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""df9b328d-3e19-4d55-8b87-b363ce2180f5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e12587eb-6fef-49da-8ea2-5639a419e541"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4c41209-0011-46e0-91fe-210de67b2e01"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""787aa252-db2b-485b-91df-c886ca6889fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f706f9e6-91c2-47f7-a528-f703615fe4f0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f10408b2-1e7d-4dbe-b86f-fc66f618ec70"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""groups"": """",
                    ""action"": ""LookDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14ff7398-fb3b-4aad-a46c-5776489455e5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c29791b5-ad84-48b8-a28b-7f9fc41ff7f9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddf3d29a-c6cc-4cd7-af23-85f44d1ec93a"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0.1),Invert"",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3789536a-16ff-4409-b7e5-8ac630a304b9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df640d72-e032-4852-808d-495f215c9c9d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa9e117b-f5d4-49e4-b431-f90b8df669fa"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39dce1d2-a182-4885-a5ac-fa83a5b86f7b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83ae0f87-a0ba-46ae-bda3-8d91c2139b3c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.2,max=1),ScaleVector2(x=70,y=70)"",
                    ""groups"": """",
                    ""action"": ""LookConst"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e03fc0c-1dee-4961-86a1-2083373cf03a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""211fc4e7-5df2-42bd-a0a8-2ba99b872579"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ffbfe814-24d9-4578-95ef-79b6fb432177"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13f4b2f5-2ab5-4681-87fd-dd9aceed3773"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""627c7565-ac74-43f6-bc92-ee70876a24a4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""713ad8c1-e228-4c33-84af-3e35c0b6414f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a5e1f96-8ca1-4065-bb53-ae9597a5bcd2"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""91914b98-effb-40a2-960a-1d355e60858e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpectatorVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefaultMap
        m_DefaultMap = asset.FindActionMap("DefaultMap", throwIfNotFound: true);
        m_DefaultMap_Move = m_DefaultMap.FindAction("Move", throwIfNotFound: true);
        m_DefaultMap_LookDelta = m_DefaultMap.FindAction("LookDelta", throwIfNotFound: true);
        m_DefaultMap_LookConst = m_DefaultMap.FindAction("LookConst", throwIfNotFound: true);
        m_DefaultMap_Scroll = m_DefaultMap.FindAction("Scroll", throwIfNotFound: true);
        m_DefaultMap_Jump = m_DefaultMap.FindAction("Jump", throwIfNotFound: true);
        m_DefaultMap_Shoot = m_DefaultMap.FindAction("Shoot", throwIfNotFound: true);
        m_DefaultMap_Aim = m_DefaultMap.FindAction("Aim", throwIfNotFound: true);
        m_DefaultMap_ToggleMenu = m_DefaultMap.FindAction("ToggleMenu", throwIfNotFound: true);
        m_DefaultMap_SpectatorVertical = m_DefaultMap.FindAction("SpectatorVertical", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // DefaultMap
    private readonly InputActionMap m_DefaultMap;
    private List<IDefaultMapActions> m_DefaultMapActionsCallbackInterfaces = new List<IDefaultMapActions>();
    private readonly InputAction m_DefaultMap_Move;
    private readonly InputAction m_DefaultMap_LookDelta;
    private readonly InputAction m_DefaultMap_LookConst;
    private readonly InputAction m_DefaultMap_Scroll;
    private readonly InputAction m_DefaultMap_Jump;
    private readonly InputAction m_DefaultMap_Shoot;
    private readonly InputAction m_DefaultMap_Aim;
    private readonly InputAction m_DefaultMap_ToggleMenu;
    private readonly InputAction m_DefaultMap_SpectatorVertical;
    public struct DefaultMapActions
    {
        private @FPSInputActions m_Wrapper;
        public DefaultMapActions(@FPSInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_DefaultMap_Move;
        public InputAction @LookDelta => m_Wrapper.m_DefaultMap_LookDelta;
        public InputAction @LookConst => m_Wrapper.m_DefaultMap_LookConst;
        public InputAction @Scroll => m_Wrapper.m_DefaultMap_Scroll;
        public InputAction @Jump => m_Wrapper.m_DefaultMap_Jump;
        public InputAction @Shoot => m_Wrapper.m_DefaultMap_Shoot;
        public InputAction @Aim => m_Wrapper.m_DefaultMap_Aim;
        public InputAction @ToggleMenu => m_Wrapper.m_DefaultMap_ToggleMenu;
        public InputAction @SpectatorVertical => m_Wrapper.m_DefaultMap_SpectatorVertical;
        public InputActionMap Get() { return m_Wrapper.m_DefaultMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultMapActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultMapActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @LookDelta.started += instance.OnLookDelta;
            @LookDelta.performed += instance.OnLookDelta;
            @LookDelta.canceled += instance.OnLookDelta;
            @LookConst.started += instance.OnLookConst;
            @LookConst.performed += instance.OnLookConst;
            @LookConst.canceled += instance.OnLookConst;
            @Scroll.started += instance.OnScroll;
            @Scroll.performed += instance.OnScroll;
            @Scroll.canceled += instance.OnScroll;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @ToggleMenu.started += instance.OnToggleMenu;
            @ToggleMenu.performed += instance.OnToggleMenu;
            @ToggleMenu.canceled += instance.OnToggleMenu;
            @SpectatorVertical.started += instance.OnSpectatorVertical;
            @SpectatorVertical.performed += instance.OnSpectatorVertical;
            @SpectatorVertical.canceled += instance.OnSpectatorVertical;
        }

        private void UnregisterCallbacks(IDefaultMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @LookDelta.started -= instance.OnLookDelta;
            @LookDelta.performed -= instance.OnLookDelta;
            @LookDelta.canceled -= instance.OnLookDelta;
            @LookConst.started -= instance.OnLookConst;
            @LookConst.performed -= instance.OnLookConst;
            @LookConst.canceled -= instance.OnLookConst;
            @Scroll.started -= instance.OnScroll;
            @Scroll.performed -= instance.OnScroll;
            @Scroll.canceled -= instance.OnScroll;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @ToggleMenu.started -= instance.OnToggleMenu;
            @ToggleMenu.performed -= instance.OnToggleMenu;
            @ToggleMenu.canceled -= instance.OnToggleMenu;
            @SpectatorVertical.started -= instance.OnSpectatorVertical;
            @SpectatorVertical.performed -= instance.OnSpectatorVertical;
            @SpectatorVertical.canceled -= instance.OnSpectatorVertical;
        }

        public void RemoveCallbacks(IDefaultMapActions instance)
        {
            if (m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultMapActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultMapActions @DefaultMap => new DefaultMapActions(this);
    public interface IDefaultMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLookDelta(InputAction.CallbackContext context);
        void OnLookConst(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnToggleMenu(InputAction.CallbackContext context);
        void OnSpectatorVertical(InputAction.CallbackContext context);
    }
}
