import { Component, OnInit } from '@angular/core';
import { AppService } from '../app-service.service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

    constructor(public svc: AppService) { }

    vaccines: any[] = []
    ngOnInit(): void {
        this.getData();
    }
    doSearch() {
        this.getData();
    }

    getData() {
        this.svc.getVaccines(this.searchText, this.vType).subscribe(val => {
            this.vaccines = val;
        })
    }

    searchText: string = '';
    vType: any = -1;

    ChangingValue(e: any) {
        this.getData();
    }
}
