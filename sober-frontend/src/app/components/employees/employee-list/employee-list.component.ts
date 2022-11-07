import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  pageTitle: string = "Employee List";
  employees: Employee[] = [
    {
      Id: '53453sdffs2342sdfsdsdf',
      Name: 'Raju',
      Email: 'raju@gmail.com',
      Phone: 643534,
      Salary: 60000,
      Department: 'CSE'
    },
    {
      Id: '53453sdf2s2342sdfsdsdf',
      Name: 'Rajib',
      Email: 'rajib@gmail.com',
      Phone: 242342,
      Salary: 60000,
      Department: 'EEE'
    },
    {
      Id: '53453sdffs3342sdfsdsdf',
      Name: 'Saidul',
      Email: 'saidul@gmail.com',
      Phone: 2342342,
      Salary: 60000,
      Department: 'SWE'
    },
    


  ];
  constructor() { }

  ngOnInit(): void {

  }

}
