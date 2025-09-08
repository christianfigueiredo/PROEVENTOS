import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {
  public eventos: any = [
    {
      Tema: 'Angular 11 e .NET 5',
      local: 'Belo Horizonte - MG',
      dataEvento: '2021-11-26'
  },
    {
      Tema: 'Angular e .NET',
      local: 'São Paulo - SP',
      dataEvento: '2021-11-27'
  },
    {
      Tema: 'Angular e .NET',
      local: 'Rio de Janeiro - RJ',
      dataEvento: '2021-11-28'
  }
];

  constructor() { }

  ngOnInit(): void {
  }

}
