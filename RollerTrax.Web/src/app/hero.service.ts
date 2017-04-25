import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { Http, Headers, RequestOptions } from '@angular/http';
import 'rxjs/add/operator/toPromise';

const HEROES: Hero[] = [
  { id: 11, name: 'Mr. Nice' },
  { id: 12, name: 'Narco' },
  { id: 13, name: 'Bombasto' },
  { id: 14, name: 'Celeritas' },
  { id: 15, name: 'Magneta' },
  { id: 16, name: 'RubberMan' },
  { id: 17, name: 'Dynama' },
  { id: 18, name: 'Dr IQ' },
  { id: 19, name: 'Magma' },
  { id: 20, name: 'Tornado' }
];

@Injectable()
export class HeroService {

    constructor(private http: Http) {
    }

    getHeroes(): Promise<Hero[]> {
        //return Promise.resolve(HEROES);                
        return this.http.get("api/Heroes").toPromise().then(response => JSON.parse(response.text()));
    }

    getHero(id: number): Promise<Hero> {
        return this.getHeroes()
             .then(heroes => heroes.find(hero => hero.id === id));
    }

    getTestCall(): Promise<string> {
        return this.http.get("api/Heroes/5").toPromise().then(response => JSON.parse(response.text()));
    }
}