// GENERATED FROM "components/lamp.comp"
// DO NOT EDIT!

namespace Sandbox.Generated;

[global::ClassNameAttribute( "components/lamp.comp" )]
[global::Sandbox.Internal.SourceLocationAttribute( "components/lamp.comp", 0 )]
[global::TitleAttribute( "Lamp" )]
[global::GroupAttribute( "Custom" )]
[global::IconAttribute( "tungsten" )]
public sealed class Component_e3754089 : global::Sandbox.Component
{

    #region Properties

    #region Renderer

    [global::Sandbox.PropertyAttribute]
    [global::TitleAttribute( "Renderer" )]
    public global::Sandbox.ModelRenderer Property1 { get; set; }
    #endregion Renderer

    #region Light

    [global::Sandbox.PropertyAttribute]
    [global::TitleAttribute( "Light" )]
    public global::Sandbox.PointLight Property2 { get; set; }
    #endregion Light

    #region Is Lit

    [global::Sandbox.PropertyAttribute]
    [global::TitleAttribute( "Is Lit" )]
    public global::System.Boolean Property5 { get; set; }
    #endregion Is Lit

    #endregion Properties

    #region Methods

    #region Update Lit State

    private delegate void Method6_Delegate( [global::Sandbox.ActionGraphTargetAttribute] global::Sandbox.Generated.Component_e3754089 _target );
    [global::Sandbox.SkipHotloadAttribute]
    private static Method6_Delegate Method6_Body;

    [global::Sandbox.Internal.SourceLocationAttribute( "components/lamp.comp", 0 )]
    [global::TitleAttribute( "Update Lit State" )]
    public void Method6(  )
    {
        Method6_Body ??= global::Sandbox.ActionGraphs.ActionGraphCache.GetOrAdd<Component_e3754089, Method6_Delegate>( 
        """
        {
          "__version": 7,
          "__guid": "5c88e04f-8334-4692-bc46-f561141d3eb8",
          "UserData": {
            "Title": "Update Lit State",
            "ReferencedComponentTypes": []
          },
          "Parameters": {
            "DefaultSignals": true
          },
          "Variables": [],
          "Nodes": [
            {
              "Id": 0,
              "Type": "input"
            },
            {
              "Id": 4,
              "Type": "property",
              "Properties": {
                "_type": "Sandbox.Component",
                "_name": "Enabled"
              },
              "UserData": {
                "Position": "224,0"
              }
            },
            {
              "Id": 6,
              "Type": "property",
              "Properties": {
                "_type": "Sandbox.ModelRenderer",
                "_name": "MaterialOverride"
              },
              "UserData": {
                "Position": "560,0"
              }
            },
            {
              "Id": 7,
              "Type": "resource.ref",
              "Properties": {
                "value": "materials/lamp_off.vmat",
                "T": "Sandbox.Material"
              },
              "UserData": {
                "Position": "128,240"
              }
            },
            {
              "Id": 9,
              "Type": "property",
              "ParentId": 4,
              "Properties": {
                "_name": "Property5"
              }
            },
            {
              "Id": 10,
              "Type": "property",
              "ParentId": 4,
              "Properties": {
                "_name": "Property2"
              }
            },
            {
              "Id": 11,
              "Type": "property",
              "ParentId": 6,
              "Properties": {
                "_name": "Property1"
              }
            },
            {
              "Id": 12,
              "Type": "op.conditional",
              "UserData": {
                "Position": "384,96"
              }
            },
            {
              "Id": 13,
              "Type": "property",
              "ParentId": 12,
              "Properties": {
                "_name": "Property5"
              }
            },
            {
              "Id": 15,
              "Type": "resource.ref",
              "Properties": {
                "value": "materials/lamp.vmat",
                "T": "Sandbox.Material"
              },
              "UserData": {
                "Position": "96,128"
              }
            }
          ],
          "Links": [
            {
              "SrcId": 0,
              "SrcName": "_signal",
              "DstId": 4,
              "DstName": "_signal"
            },
            {
              "SrcId": 10,
              "SrcName": "_result",
              "DstId": 4,
              "DstName": "_target"
            },
            {
              "SrcId": 9,
              "SrcName": "_result",
              "DstId": 4,
              "DstName": "_value"
            },
            {
              "SrcId": 4,
              "SrcName": "_signal",
              "DstId": 6,
              "DstName": "_signal"
            },
            {
              "SrcId": 11,
              "SrcName": "_result",
              "DstId": 6,
              "DstName": "_target"
            },
            {
              "SrcId": 12,
              "SrcName": "_result",
              "DstId": 6,
              "DstName": "_value"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 9,
              "DstName": "_target"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 10,
              "DstName": "_target"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 11,
              "DstName": "_target"
            },
            {
              "SrcId": 15,
              "SrcName": "_result",
              "DstId": 12,
              "DstName": "a"
            },
            {
              "SrcId": 7,
              "SrcName": "_result",
              "DstId": 12,
              "DstName": "b"
            },
            {
              "SrcId": 13,
              "SrcName": "_result",
              "DstId": 12,
              "DstName": "x"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 13,
              "DstName": "_target"
            }
          ]
        }
        """ );

        Method6_Body( this );
    }

    #endregion Update Lit State

    #region On Enabled

    private delegate void OnEnabled_Delegate( [global::Sandbox.ActionGraphTargetAttribute] global::Sandbox.Component _target );
    [global::Sandbox.SkipHotloadAttribute]
    private static OnEnabled_Delegate OnEnabled_Body;

    [global::Sandbox.Internal.SourceLocationAttribute( "components/lamp.comp", 0 )]
    [global::TitleAttribute( "On Enabled" )]
    protected override void OnEnabled(  )
    {
        OnEnabled_Body ??= global::Sandbox.ActionGraphs.ActionGraphCache.GetOrAdd<Component_e3754089, OnEnabled_Delegate>( 
        """
        {
          "__version": 7,
          "__guid": "5f6ced9f-c004-4875-825f-594072a5415c",
          "UserData": {
            "Title": "On Enabled",
            "ReferencedComponentTypes": []
          },
          "Variables": [],
          "Nodes": [
            {
              "Id": 0,
              "Type": "input"
            },
            {
              "Id": 1,
              "Type": "call",
              "Properties": {
                "_type": "components/lamp.comp",
                "_isStatic": false,
                "_name": "Method6"
              },
              "UserData": {
                "Position": "176,0"
              }
            }
          ],
          "Links": [
            {
              "SrcId": 0,
              "SrcName": "_signal",
              "DstId": 1,
              "DstName": "_signal"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 1,
              "DstName": "_target"
            }
          ]
        }
        """ );

        OnEnabled_Body( this );
    }

    #endregion On Enabled

    #region On Update

    private delegate void OnUpdate_Delegate( [global::Sandbox.ActionGraphTargetAttribute] global::Sandbox.Component _target );
    [global::Sandbox.SkipHotloadAttribute]
    private static OnUpdate_Delegate OnUpdate_Body;

    [global::Sandbox.Internal.SourceLocationAttribute( "components/lamp.comp", 0 )]
    [global::TitleAttribute( "On Update" )]
    protected override void OnUpdate(  )
    {
        OnUpdate_Body ??= global::Sandbox.ActionGraphs.ActionGraphCache.GetOrAdd<Component_e3754089, OnUpdate_Delegate>( 
        """
        {
          "__version": 7,
          "__guid": "bd5afd3b-519b-4d0e-9650-70448a3f5841",
          "UserData": {
            "Title": "On Update",
            "ReferencedComponentTypes": []
          },
          "Variables": [],
          "Nodes": [
            {
              "Id": 0,
              "Type": "input"
            },
            {
              "Id": 1,
              "Type": "call",
              "Properties": {
                "_type": "components/lamp.comp",
                "_isStatic": false,
                "_name": "Method6"
              },
              "UserData": {
                "Position": "160,0"
              }
            }
          ],
          "Links": [
            {
              "SrcId": 0,
              "SrcName": "_signal",
              "DstId": 1,
              "DstName": "_signal"
            },
            {
              "SrcId": 0,
              "SrcName": "_target",
              "DstId": 1,
              "DstName": "_target"
            }
          ]
        }
        """ );

        OnUpdate_Body( this );
    }

    #endregion On Update

    #endregion Methods

    #region Events

    #endregion Events

}

