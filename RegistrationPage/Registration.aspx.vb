Public Class Registration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Your Registration is successful.")
    End Sub

    Protected Sub DropDownListCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListCountry.SelectedIndexChanged

    End Sub
End Class