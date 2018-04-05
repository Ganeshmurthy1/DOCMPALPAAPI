// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

import { Component, OnInit, OnDestroy, Input } from "@angular/core";
import { fadeInOut } from '../../services/animations';



import { DashboardService } from "../../services/dashboard.service";
import { ItemOfInterest } from '../../models/itemofinterest.model';




@Component({
    selector: 'dashboard',
    templateUrl: './orders.component.html',
    styleUrls: ['./orders.component.css'],
    animations: [fadeInOut]
})
export class OrdersComponent implements OnInit, OnDestroy {

     items: ItemOfInterest[];

    constructor(private dashboardService: DashboardService) {
    }

    ngOnInit() {

        this.getDashboardItems();
    }


    getDashboardItems() {

        this.dashboardService.getDashboardItems().subscribe(items => this.onDataLoadSuccessful(items));
    }
    onDataLoadSuccessful(itemOfInterests: ItemOfInterest[]) {
        this.items = itemOfInterests;

        itemOfInterests.forEach((itemOfInterest, index, itemOfInterests) => {
            console.log(itemOfInterest.description);
        });
    }

    ngOnDestroy() {
    }
}
