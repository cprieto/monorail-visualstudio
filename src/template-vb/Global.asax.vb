Imports Castle.MonoRail.Framework.Routing

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start (ByVal sender As Object, ByVal e As EventArgs)
        RegisterRules (RoutingModuleEx.Engine)
    End Sub

    Private Shared Sub RegisterRules (ByVal rules As IRoutingRuleContainer)
        Dim rootRoute As New PatternRoute ("root", "/")
        With rootRoute
            .DefaultForController().Is ("Home")
            .DefaultForAction().Is ("Index")
        End With
        rules.Add (rootRoute)

        Dim defaultRoute As New PatternRoute ("standard", "[controller]/[action]/[id]")
        With defaultRoute
            .DefaultForController().Is ("Home")
            .DefaultForAction().Is ("Index")
        End With
        rules.Add (defaultRoute)
    End Sub
End Class