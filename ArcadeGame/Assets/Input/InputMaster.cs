// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""32d4c5e2-2c23-4b84-b723-76bd3cf7a36a"",
            ""actions"": [
                {
                    ""name"": ""Key1"",
                    ""type"": ""Button"",
                    ""id"": ""27966f7d-7085-4f8d-8749-acba030060b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Key2"",
                    ""type"": ""Button"",
                    ""id"": ""026ff1a7-6370-49ad-bf22-30133c4c4457"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Key3"",
                    ""type"": ""Button"",
                    ""id"": ""19d6cac5-637a-4662-a451-6cc385a023f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Key4"",
                    ""type"": ""Button"",
                    ""id"": ""915a29e9-608e-4f49-bec1-39730a5d18b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyL"",
                    ""type"": ""Button"",
                    ""id"": ""5f6f7c5d-a4cb-40e6-955d-6bffb374cb57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyR"",
                    ""type"": ""Button"",
                    ""id"": ""54a73e0d-4a4d-4456-9ef0-238ed51a869b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyAir"",
                    ""type"": ""Button"",
                    ""id"": ""e32b9833-18b9-40b6-b4c3-bf83aa697bb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fdefbf8c-5c84-4629-b71a-5d84870e1bd5"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1557afdb-5773-45ce-8f1b-e79a30fa8aae"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79bd70dd-49ee-4779-8656-bb491e50f383"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9567e312-422e-4639-bf39-b37be8d3f765"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Key4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bb25014-d71e-4078-9672-7e7ff01abca6"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bd29151-09e8-4597-8c96-7d295803b2e2"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeb5c115-80ce-4357-a863-5370f08f305e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyAir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Key1 = m_Player.FindAction("Key1", throwIfNotFound: true);
        m_Player_Key2 = m_Player.FindAction("Key2", throwIfNotFound: true);
        m_Player_Key3 = m_Player.FindAction("Key3", throwIfNotFound: true);
        m_Player_Key4 = m_Player.FindAction("Key4", throwIfNotFound: true);
        m_Player_KeyL = m_Player.FindAction("KeyL", throwIfNotFound: true);
        m_Player_KeyR = m_Player.FindAction("KeyR", throwIfNotFound: true);
        m_Player_KeyAir = m_Player.FindAction("KeyAir", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Key1;
    private readonly InputAction m_Player_Key2;
    private readonly InputAction m_Player_Key3;
    private readonly InputAction m_Player_Key4;
    private readonly InputAction m_Player_KeyL;
    private readonly InputAction m_Player_KeyR;
    private readonly InputAction m_Player_KeyAir;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Key1 => m_Wrapper.m_Player_Key1;
        public InputAction @Key2 => m_Wrapper.m_Player_Key2;
        public InputAction @Key3 => m_Wrapper.m_Player_Key3;
        public InputAction @Key4 => m_Wrapper.m_Player_Key4;
        public InputAction @KeyL => m_Wrapper.m_Player_KeyL;
        public InputAction @KeyR => m_Wrapper.m_Player_KeyR;
        public InputAction @KeyAir => m_Wrapper.m_Player_KeyAir;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Key1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey1;
                @Key1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey1;
                @Key1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey1;
                @Key2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey2;
                @Key2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey2;
                @Key2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey2;
                @Key3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey3;
                @Key3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey3;
                @Key3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey3;
                @Key4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey4;
                @Key4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey4;
                @Key4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKey4;
                @KeyL.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyL;
                @KeyL.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyL;
                @KeyL.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyL;
                @KeyR.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyR;
                @KeyR.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyR;
                @KeyR.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyR;
                @KeyAir.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyAir;
                @KeyAir.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyAir;
                @KeyAir.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnKeyAir;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Key1.started += instance.OnKey1;
                @Key1.performed += instance.OnKey1;
                @Key1.canceled += instance.OnKey1;
                @Key2.started += instance.OnKey2;
                @Key2.performed += instance.OnKey2;
                @Key2.canceled += instance.OnKey2;
                @Key3.started += instance.OnKey3;
                @Key3.performed += instance.OnKey3;
                @Key3.canceled += instance.OnKey3;
                @Key4.started += instance.OnKey4;
                @Key4.performed += instance.OnKey4;
                @Key4.canceled += instance.OnKey4;
                @KeyL.started += instance.OnKeyL;
                @KeyL.performed += instance.OnKeyL;
                @KeyL.canceled += instance.OnKeyL;
                @KeyR.started += instance.OnKeyR;
                @KeyR.performed += instance.OnKeyR;
                @KeyR.canceled += instance.OnKeyR;
                @KeyAir.started += instance.OnKeyAir;
                @KeyAir.performed += instance.OnKeyAir;
                @KeyAir.canceled += instance.OnKeyAir;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnKey1(InputAction.CallbackContext context);
        void OnKey2(InputAction.CallbackContext context);
        void OnKey3(InputAction.CallbackContext context);
        void OnKey4(InputAction.CallbackContext context);
        void OnKeyL(InputAction.CallbackContext context);
        void OnKeyR(InputAction.CallbackContext context);
        void OnKeyAir(InputAction.CallbackContext context);
    }
}
