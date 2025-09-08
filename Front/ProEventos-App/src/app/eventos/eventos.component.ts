import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {
  public eventos: any;

  constructor() { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.eventos = [
      { Tema: 'Angular 11 e .NET 5', local: 'Belo Horizonte', dataEvento: '2021-06-25' },
      { Tema: 'Angular e .NET Core', local: 'São Paulo', dataEvento: '2021-06-26' },
      { Tema: 'Angular e Java', local: 'Rio de Janeiro', dataEvento: '2021-06-27' }
     ];

}
}
