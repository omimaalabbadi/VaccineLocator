import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-details',
    templateUrl: './details.component.html',
    styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {

    constructor() { }

    ngOnInit(): void {
        navigator.geolocation.getCurrentPosition((position) => {
            this.center = {
                lat: position.coords.latitude,
                lng: position.coords.longitude,
            }
        })
    }
    center!: google.maps.LatLngLiteral;
    options: google.maps.MapOptions = {
        mapTypeId: 'satellite',
        zoomControl: true,
        scrollwheel: true,
        disableDoubleClickZoom: false,
        maxZoom: 15,
        minZoom: 8,
    }
}
