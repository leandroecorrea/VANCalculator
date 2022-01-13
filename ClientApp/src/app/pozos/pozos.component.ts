import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pozos',
  templateUrl: './pozos.component.html'
})
export class PozoComponent {
  public pozos: Pozo[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Pozo[]>(baseUrl + 'pozos').subscribe(result => {
      this.pozos = result;
    }, error => console.error(error));
  }
}

interface Pozo {
  precio: number;
  inversion: number;
  VAN: number;
}
