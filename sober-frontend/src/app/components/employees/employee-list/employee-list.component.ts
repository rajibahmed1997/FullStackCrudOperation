import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  pageTitle: string = "Employee List";
  employees: Employee[] = [
    {
      Id:'24342sdfsd234',
      Name:'one',
      Email:'one@gmail.com',
      Phone:2342342,
      Salary:234234,
      Department:'cse'
    },
    {
      Id:'24342sdfsd234',
      Name:'one',
      Email:'one@gmail.com',
      Phone:2342342,
      Salary:234234,
      Department:'cse'
    },

  ];
  constructor(private employeesService : EmployeesService) { }

  ngOnInit(): void {
    this.employeesService.getAllEmployees().subscribe({
      next: (employees) => {
        this.employees = employees;
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

}
