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
      id: '53453sdffs2342sdfsdsdf',
      name: 'Rajib',
      email: 'rajib@gmail.com',
      phone: 242342,
      salary: 60000,
      department: 'CSE'
    },
    {
      id: '53453sdffsbc42sdfsdsdf',
      name: 'Saidul',
      email: 'saidul@gmail.com',
      phone: 242342,
      salary: 60000,
      department: 'CSE'
    },
    {
      id: '53453sdffssd42sdfsdsdf',
      name: 'second',
      email: 'second@gmail.com',
      phone: 242342,
      salary: 60000,
      department: 'EEE'
    },
    {
      id: '53453sd32s2342sdfsdsdf',
      name: 'Rajib',
      email: 'rajib@gmail.com',
      phone: 242342,
      salary: 60000,
      department: 'SWE'
    }

  ];
  constructor() { }

  ngOnInit(): void {

  }

}
