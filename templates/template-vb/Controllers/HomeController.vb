Imports Castle.MonoRail.Framework

Namespace Controllers
    <Layout("Default"), Rescue("500")> _
    Public Class HomeController
        Inherits SmartDispatcherController

        Sub Index()
            PropertyBag("message") = "Welcome to Castle MonoRail!"
        End Sub

        Sub About()
        End Sub
    End Class
End Namespace