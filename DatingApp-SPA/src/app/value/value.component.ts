import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  /*declare property with type "any"*/
  values: any;

  /* Import from angular one*/
    constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getValues();
  }

  /* create a method */
  getValues() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response;
    }, error => {
      console.log(error);
    });
  }

}
