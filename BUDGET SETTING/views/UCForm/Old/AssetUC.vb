Public Class AssetUC
    Public AssetsDT As DataTable
    Private Sub AssetUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadAsset()
    End Sub
    Sub Custom_LoadAsset()
        Dim SqlLoad As New MySQLCore
        AssetsDT = SqlLoad.MySql_SelectString("*", "vi_assets")
        DataGridView1.DataSource = AssetsDT

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Assettxt.Text = DataGridView1.Rows(e.RowIndex).Cells("ASSET NAME").Value.ToString()
        AssetDescrptiontxt.Text = DataGridView1.Rows(e.RowIndex).Cells("ASSET DESCRIPTION").Value.ToString()
    End Sub
    Private Sub Searchtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Searchtxt.OnValueChanged

        Dim conditions As New List(Of LinQCondition) From {
        New LinQCondition With {
                              .Column = "asset name",
                              .Value = Searchtxt.Text,
                              .ComparisonType = ComparisonTypeEnum.Like_enum}
      }
        DataGridView1.DataSource = Linq_Query(AssetsDT, conditions)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
