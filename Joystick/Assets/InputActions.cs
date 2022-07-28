//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PressKey"",
            ""id"": ""47f868ae-18a1-4889-ab1f-e17c5e060c0d"",
            ""actions"": [
                {
                    ""name"": ""Space"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a9858ce1-13ba-4609-b22b-2f139ef81e4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ca4e8e32-74f0-4a9a-bae9-3097d7661020"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PressKey
        m_PressKey = asset.FindActionMap("PressKey", throwIfNotFound: true);
        m_PressKey_Space = m_PressKey.FindAction("Space", throwIfNotFound: true);
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

    // PressKey
    private readonly InputActionMap m_PressKey;
    private IPressKeyActions m_PressKeyActionsCallbackInterface;
    private readonly InputAction m_PressKey_Space;
    public struct PressKeyActions
    {
        private @InputActions m_Wrapper;
        public PressKeyActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_PressKey_Space;
        public InputActionMap Get() { return m_Wrapper.m_PressKey; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PressKeyActions set) { return set.Get(); }
        public void SetCallbacks(IPressKeyActions instance)
        {
            if (m_Wrapper.m_PressKeyActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_PressKeyActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_PressKeyActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_PressKeyActionsCallbackInterface.OnSpace;
            }
            m_Wrapper.m_PressKeyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
            }
        }
    }
    public PressKeyActions @PressKey => new PressKeyActions(this);
    public interface IPressKeyActions
    {
        void OnSpace(InputAction.CallbackContext context);
    }
}
