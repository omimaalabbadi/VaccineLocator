import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
    providedIn: 'root'
})
export class AppService {

    constructor(public http: HttpClient) { }

    getVaccines(searchText: string = '', vType: number = -1): Observable<any> {
        return this.http.get("https://localhost:44355/api/Vaccines/GetVaccines?searchText=" + searchText + "&vType=" + vType);
    }
}
