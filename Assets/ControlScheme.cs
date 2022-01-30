// GENERATED AUTOMATICALLY FROM 'Assets/ControlScheme.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlScheme : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlScheme()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlScheme"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""4a169cb9-4ae4-4617-bb18-b63a31032273"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""167416bb-056f-41db-85c5-4bdfc1e217e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Scale"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f5d2c2c1-4726-459f-a3d4-6882ba8ab4dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""NeutralSpecial"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c68fbe65-d6d3-45a2-98e2-c2d2d4dbb368"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpSpecial"",
                    ""type"": ""Button"",
                    ""id"": ""50bb93b8-14a1-4d2f-9a66-90beb60773c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""DownSpecial"",
                    ""type"": ""PassThrough"",
                    ""id"": ""69c76f74-192b-45c3-9111-8d2261abf02a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""SideSpecial"",
                    ""type"": ""Button"",
                    ""id"": ""f1fa5340-44c4-4310-80ac-803431591af4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Switch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""405a6c06-79ca-4c71-ae8c-4cc95577d0ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""babb72d2-a741-4080-93bb-d71296f41f11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DashAttack"",
                    ""type"": ""Button"",
                    ""id"": ""0d82257d-82ab-42fb-b0fb-7138359ccfc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DownTilt"",
                    ""type"": ""Button"",
                    ""id"": ""25c7fec9-fe75-4811-9ad2-b94ccca89cf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForwardTilt"",
                    ""type"": ""Button"",
                    ""id"": ""ebbc5b90-ba1e-45e6-afe3-e5a13f0760e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpTilt"",
                    ""type"": ""Button"",
                    ""id"": ""5e78cae5-4242-448c-bfe6-e60d0e2c6152"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Walk Gamepad"",
                    ""id"": ""2d1e9ed9-674c-45b1-a61d-5f18ee39f6ed"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": ""Hold"",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""96d17c26-d810-4335-93d2-7a5d6f1c43d5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4cd5a745-79e3-4607-a797-7d88cca5175a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Walk Keyboard"",
                    ""id"": ""036b6288-6d34-4af8-a382-c1624beef9c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""56e1b50b-a1a9-4f04-bd80-61ff318efb84"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7b49705b-7bdb-4271-84c4-5108d2e19a1f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down Special Gamepad"",
                    ""id"": ""9fd417be-b466-4c0d-b3df-75b5d26722e4"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""316ed370-5a02-4520-a54b-e6a5b4b792b4"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""3e1b41c7-4249-4291-9a3c-974e29091158"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down Special Keyboard"",
                    ""id"": ""79c5b8c2-3952-48f3-8d15-aeb8867762c9"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""13562a57-2f14-4f07-81f1-cdc7349df469"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""cbc2c953-d67a-4290-a4f3-166bd1392969"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Side Special Gamepad Left"",
                    ""id"": ""9f8f4cef-0085-45c1-a417-a6d2c3706e44"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""cefde2cb-7102-4ae1-b682-0ca59fc44c06"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""47dbd777-488b-433d-9461-922bdc731f23"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Side Special Gamepad Right"",
                    ""id"": ""90cb51de-9e01-43d7-a566-8a165db8644d"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ee1fd37b-a245-4c24-843d-c50aa0dc23dd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ce16d768-1236-44b5-9916-4b3c507a4075"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Side Special Keyboard Left"",
                    ""id"": ""1884804e-42a5-4b2c-aede-c4227c572f46"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""1f5a48ce-ffb8-4847-aecb-b96b21a038ed"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""7b31301a-0581-4ff0-ac01-863a658510c3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Side Special Keyboard Right"",
                    ""id"": ""5f457a5c-bc5e-4af1-bd55-02da749f6808"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""de89c736-84ec-4f9c-9799-83bde96f940c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""ee93c8a1-e4bf-44bf-b133-34a0ef6c90ef"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5674951b-85ef-4133-8732-d3cf2980951f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.3)"",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1aca328-ef98-49cb-940e-8512a3d9f282"",
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
                    ""id"": ""dab37de8-0757-419a-bfa5-071bc959cdbb"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d696bbf-2ad9-4dfa-b781-47c1a5523aa2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""NeutralSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7ff2299-349a-4bec-ba0e-a6f601eeb82a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NeutralSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up Special Gamepad"",
                    ""id"": ""17acd2b4-793c-460f-9d4d-61f4a69fe529"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""4a7a8d3d-42a9-4956-9074-0111d5e74bf1"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""11722996-22c3-477e-b383-0879f39e91f9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Up Special Keyboard"",
                    ""id"": ""8157e209-4825-4170-9b6d-edf53f31a7b1"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ee7af77a-5e81-4b42-8ee2-271feac19b5f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""8fd6d651-22bc-4bb7-a619-bf43572a6586"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpSpecial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Switch Gamepad"",
                    ""id"": ""235e25ec-dff9-43b9-a359-c13f566bfc10"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ce3adca4-c275-44ef-a2e6-f068a7e288bd"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5e3ea326-0ec6-4de5-9931-ad68463e164b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Switch Keyboard"",
                    ""id"": ""0c50df71-7903-46fa-85a6-c0d4abafb256"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""61727afa-390e-46d9-9538-db534e8de03e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7ac485d1-f0f7-48ec-881e-626387bf5a8d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dd249559-051d-4bae-be8f-974f74d6d80e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""830f9c0f-6fc9-41bc-9fd6-d5defbebe83a"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e2da88c1-87cc-4dbc-9d45-d07a02d6c744"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""45e66bad-3cc1-4977-ad64-60a9815ca431"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0602c93-48f4-45ee-9eae-11e1f6d60431"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6a656036-b8e8-4d0e-b9b0-0c95486bb3ec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f3ee77ff-c2df-4272-9cb8-f815913df04b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""51482d7c-c721-417b-8ae8-a61a0d8028ff"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2d882e91-b57f-4d2b-befe-b9ba98fa1584"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""788750a2-f092-43ac-8969-2cddecc84a15"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0dafbabc-7cc2-46c3-b4e9-62e5b65fd863"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0e5596f-145c-4420-9ca2-2f1959b101d7"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""UpTilt Keyboard"",
                    ""id"": ""7a327f68-ca36-4e95-801b-869280a98c10"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpTilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""34b88371-4fd3-4ca7-83e1-f926ffa6ae73"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""b21c9673-5561-4872-b4ca-a077c37dc8bb"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DownTilt Keyboard"",
                    ""id"": ""bd781682-69cf-458a-95a0-dcf14ffe003f"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownTilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""9e3b4636-4003-4c58-807f-0b447a796c16"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""3f9fb5c2-61f8-4040-bcad-0781520d980f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": []
        }
    ]
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Move = m_Main.FindAction("Move", throwIfNotFound: true);
        m_Main_Jump = m_Main.FindAction("Jump", throwIfNotFound: true);
        m_Main_NeutralSpecial = m_Main.FindAction("NeutralSpecial", throwIfNotFound: true);
        m_Main_UpSpecial = m_Main.FindAction("UpSpecial", throwIfNotFound: true);
        m_Main_DownSpecial = m_Main.FindAction("DownSpecial", throwIfNotFound: true);
        m_Main_SideSpecial = m_Main.FindAction("SideSpecial", throwIfNotFound: true);
        m_Main_Switch = m_Main.FindAction("Switch", throwIfNotFound: true);
        m_Main_Direction = m_Main.FindAction("Direction", throwIfNotFound: true);
        m_Main_DashAttack = m_Main.FindAction("DashAttack", throwIfNotFound: true);
        m_Main_DownTilt = m_Main.FindAction("DownTilt", throwIfNotFound: true);
        m_Main_ForwardTilt = m_Main.FindAction("ForwardTilt", throwIfNotFound: true);
        m_Main_UpTilt = m_Main.FindAction("UpTilt", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_Move;
    private readonly InputAction m_Main_Jump;
    private readonly InputAction m_Main_NeutralSpecial;
    private readonly InputAction m_Main_UpSpecial;
    private readonly InputAction m_Main_DownSpecial;
    private readonly InputAction m_Main_SideSpecial;
    private readonly InputAction m_Main_Switch;
    private readonly InputAction m_Main_Direction;
    private readonly InputAction m_Main_DashAttack;
    private readonly InputAction m_Main_DownTilt;
    private readonly InputAction m_Main_ForwardTilt;
    private readonly InputAction m_Main_UpTilt;
    public struct MainActions
    {
        private @ControlScheme m_Wrapper;
        public MainActions(@ControlScheme wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Main_Move;
        public InputAction @Jump => m_Wrapper.m_Main_Jump;
        public InputAction @NeutralSpecial => m_Wrapper.m_Main_NeutralSpecial;
        public InputAction @UpSpecial => m_Wrapper.m_Main_UpSpecial;
        public InputAction @DownSpecial => m_Wrapper.m_Main_DownSpecial;
        public InputAction @SideSpecial => m_Wrapper.m_Main_SideSpecial;
        public InputAction @Switch => m_Wrapper.m_Main_Switch;
        public InputAction @Direction => m_Wrapper.m_Main_Direction;
        public InputAction @DashAttack => m_Wrapper.m_Main_DashAttack;
        public InputAction @DownTilt => m_Wrapper.m_Main_DownTilt;
        public InputAction @ForwardTilt => m_Wrapper.m_Main_ForwardTilt;
        public InputAction @UpTilt => m_Wrapper.m_Main_UpTilt;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @NeutralSpecial.started -= m_Wrapper.m_MainActionsCallbackInterface.OnNeutralSpecial;
                @NeutralSpecial.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnNeutralSpecial;
                @NeutralSpecial.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnNeutralSpecial;
                @UpSpecial.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUpSpecial;
                @UpSpecial.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUpSpecial;
                @UpSpecial.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUpSpecial;
                @DownSpecial.started -= m_Wrapper.m_MainActionsCallbackInterface.OnDownSpecial;
                @DownSpecial.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnDownSpecial;
                @DownSpecial.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnDownSpecial;
                @SideSpecial.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSideSpecial;
                @SideSpecial.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSideSpecial;
                @SideSpecial.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSideSpecial;
                @Switch.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSwitch;
                @Direction.started -= m_Wrapper.m_MainActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnDirection;
                @DashAttack.started -= m_Wrapper.m_MainActionsCallbackInterface.OnDashAttack;
                @DashAttack.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnDashAttack;
                @DashAttack.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnDashAttack;
                @DownTilt.started -= m_Wrapper.m_MainActionsCallbackInterface.OnDownTilt;
                @DownTilt.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnDownTilt;
                @DownTilt.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnDownTilt;
                @ForwardTilt.started -= m_Wrapper.m_MainActionsCallbackInterface.OnForwardTilt;
                @ForwardTilt.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnForwardTilt;
                @ForwardTilt.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnForwardTilt;
                @UpTilt.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUpTilt;
                @UpTilt.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUpTilt;
                @UpTilt.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUpTilt;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @NeutralSpecial.started += instance.OnNeutralSpecial;
                @NeutralSpecial.performed += instance.OnNeutralSpecial;
                @NeutralSpecial.canceled += instance.OnNeutralSpecial;
                @UpSpecial.started += instance.OnUpSpecial;
                @UpSpecial.performed += instance.OnUpSpecial;
                @UpSpecial.canceled += instance.OnUpSpecial;
                @DownSpecial.started += instance.OnDownSpecial;
                @DownSpecial.performed += instance.OnDownSpecial;
                @DownSpecial.canceled += instance.OnDownSpecial;
                @SideSpecial.started += instance.OnSideSpecial;
                @SideSpecial.performed += instance.OnSideSpecial;
                @SideSpecial.canceled += instance.OnSideSpecial;
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @DashAttack.started += instance.OnDashAttack;
                @DashAttack.performed += instance.OnDashAttack;
                @DashAttack.canceled += instance.OnDashAttack;
                @DownTilt.started += instance.OnDownTilt;
                @DownTilt.performed += instance.OnDownTilt;
                @DownTilt.canceled += instance.OnDownTilt;
                @ForwardTilt.started += instance.OnForwardTilt;
                @ForwardTilt.performed += instance.OnForwardTilt;
                @ForwardTilt.canceled += instance.OnForwardTilt;
                @UpTilt.started += instance.OnUpTilt;
                @UpTilt.performed += instance.OnUpTilt;
                @UpTilt.canceled += instance.OnUpTilt;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IMainActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnNeutralSpecial(InputAction.CallbackContext context);
        void OnUpSpecial(InputAction.CallbackContext context);
        void OnDownSpecial(InputAction.CallbackContext context);
        void OnSideSpecial(InputAction.CallbackContext context);
        void OnSwitch(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
        void OnDashAttack(InputAction.CallbackContext context);
        void OnDownTilt(InputAction.CallbackContext context);
        void OnForwardTilt(InputAction.CallbackContext context);
        void OnUpTilt(InputAction.CallbackContext context);
    }
}
