﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using ShipIt.Models.ApiModels;

namespace ShipIt.Models.DataModels
{
    [Table("em")]
    public class EmployeeDataModel : DataModel
    {
        [Column("em_id")] //added field
        public int EmployeeId { get; set; } //added field

        [Column("name")]
        [Key]
        public string Name { get; set; }
        [Column("w_id")]
        public int WarehouseId { get; set; }
        [Column("role")]
        public string Role { get; set; }
        [Column("ext")]
        public string Ext { get; set; }

        public EmployeeDataModel(IDataReader dataReader) : base(dataReader)
        { }

        public EmployeeDataModel()
        { }

        public EmployeeDataModel(Employee employee)
        {
            this.EmployeeId = employee.EmployeeId;
            this.Name = employee.Name;
            this.WarehouseId = employee.WarehouseId;
            this.Role = MapApiRoleToDatabaseRole(employee.role);
            this.Ext = employee.ext;
        }

        private string MapApiRoleToDatabaseRole(EmployeeRole employeeRole)
        {
            if (employeeRole == EmployeeRole.CLEANER) return DataBaseRoles.Cleaner;
            if (employeeRole == EmployeeRole.MANAGER) return DataBaseRoles.Manager;
            if (employeeRole == EmployeeRole.OPERATIONS_MANAGER) return DataBaseRoles.OperationsManager;
            if (employeeRole == EmployeeRole.PICKER) return DataBaseRoles.Picker;
            throw new ArgumentOutOfRangeException("EmployeeRole");
        }
    }
}