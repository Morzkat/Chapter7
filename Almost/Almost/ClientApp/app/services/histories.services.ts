//Angular Components
import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
//rxjs
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

//App Interfaces
import { History } from './../interfaces/history.interface';

@Injectable()

export class HistoriesService
{
    constructor(private http:Http)
    {

    }

    getAllHistories():Observable<History[]>
    {
        return this.http.get("http://localhost:54948/api/"+ "Histories")
        .map(response => response.json() as History[]);
    }
}