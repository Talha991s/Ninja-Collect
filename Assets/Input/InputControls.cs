// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""NinjaMovement"",
            ""id"": ""75d2a3e8-0161-4a11-84a8-de137414a45c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""48cf5f8a-474a-4f8d-a7b2-2c719486d4d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""09fe618a-9636-42a5-a7c4-251ffd91075f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5530a5bd-8df2-4c74-bee1-4af1030674d3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d7f046f-6b49-416c-ab3a-52a8e6acab3f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e9ce4460-6b95-481f-81cd-cb78488d611e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""34d20b67-6e24-4a62-8d99-72d5173a56c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1077cdae-966d-4ae0-8a4b-581cca5711d2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""54dd133a-3e58-4086-94c4-4b8c2aed7ee0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // NinjaMovement
        m_NinjaMovement = asset.FindActionMap("NinjaMovement", throwIfNotFound: true);
        m_NinjaMovement_Movement = m_NinjaMovement.FindAction("Movement", throwIfNotFound: true);
        m_NinjaMovement_Jump = m_NinjaMovement.FindAction("Jump", throwIfNotFound: true);
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

    // NinjaMovement
    private readonly InputActionMap m_NinjaMovement;
    private INinjaMovementActions m_NinjaMovementActionsCallbackInterface;
    private readonly InputAction m_NinjaMovement_Movement;
    private readonly InputAction m_NinjaMovement_Jump;
    public struct NinjaMovementActions
    {
        private @InputControls m_Wrapper;
        public NinjaMovementActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_NinjaMovement_Movement;
        public InputAction @Jump => m_Wrapper.m_NinjaMovement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_NinjaMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NinjaMovementActions set) { return set.Get(); }
        public void SetCallbacks(INinjaMovementActions instance)
        {
            if (m_Wrapper.m_NinjaMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NinjaMovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_NinjaMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public NinjaMovementActions @NinjaMovement => new NinjaMovementActions(this);
    public interface INinjaMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
