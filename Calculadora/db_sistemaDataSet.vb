Partial Class db_sistemaDataSet
    Partial Public Class GananciasDataTable
        Private Sub GananciasDataTable_GananciasRowChanging(sender As Object, e As GananciasRowChangeEvent) Handles Me.GananciasRowChanging

        End Sub

    End Class

    Partial Public Class comprasDataTable
        Private Sub comprasDataTable_comprasRowChanging(sender As Object, e As comprasRowChangeEvent) Handles Me.comprasRowChanging

        End Sub

    End Class

    Partial Public Class empleadosDataTable
        Private Sub empleadosDataTable_empleadosRowChanging(sender As Object, e As empleadosRowChangeEvent) Handles Me.empleadosRowChanging

        End Sub

    End Class

    Partial Public Class dcomprasDataTable
        Public Property DataColumnColumn As Object

        Private Sub dcomprasDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If e.Column.ColumnName = Me.DataColumnColumn.ColumnName Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Friend Function dcomprasproductos() As Object
        Throw New NotImplementedException()
    End Function
End Class

Namespace db_sistemaDataSetTableAdapters
    Partial Public Class comprasTableAdapter
        Friend Sub Fill(compras As db_sistemaDataSet.comprasDataTable)
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace

