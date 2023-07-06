Imports Microsoft.Reporting.WinForms

Module ReportRDLC
    Public Sub DesignRDLC(ByVal rdlc As ReportViewer,
                          ByVal rptName As String,
                          Optional ByVal parameters As Dictionary(Of String, String) = Nothing,
                          Optional ByVal DatasetDatatable As Dictionary(Of String, DataTable) = Nothing,
                          Optional ByVal displayMode As Microsoft.Reporting.WinForms.DisplayMode = DisplayMode.PrintLayout,
                          Optional ByVal pages As Integer = 1,
                          Optional ByVal zoom As Integer = 110)

        With rdlc.LocalReport
            'Setting of reportpath and filename
            Dim projname = Replace(System.Reflection.Assembly.GetCallingAssembly().GetName().Name.ToString, " ", "_")
            .ReportEmbeddedResource = projname & "." & rptName

            'Setting of report parameters
            If parameters IsNot Nothing Then
                For i As Integer = 0 To parameters.Count - 1
                    Dim hparam As New ReportParameter(parameters.Keys.ElementAt(i), parameters.Values.ElementAt(i))
                    .SetParameters(hparam)
                Next
            End If
            'Example ("datasetname", datatablename)
            'Dataset and Datatable Update 6.1.2023
            If DatasetDatatable IsNot Nothing Then
                For i As Integer = 0 To DatasetDatatable.Count - 1
                    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(DatasetDatatable.Keys.ElementAt(i), DatasetDatatable.Values.ElementAt(i)))
                Next
            End If
        End With

        With rdlc
            .SetDisplayMode(displayMode)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = zoom
            .PrinterSettings.Copies = pages
            .RefreshReport()
        End With
    End Sub
End Module
