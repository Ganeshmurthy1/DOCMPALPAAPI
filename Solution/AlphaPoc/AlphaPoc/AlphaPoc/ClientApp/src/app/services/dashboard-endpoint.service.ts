import { Injectable, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { EndpointFactory } from './endpoint-factory.service';
import { ConfigurationService } from './configuration.service';



@Injectable()
export class DashboardEndpoint extends EndpointFactory {
    private readonly _dashboardUrl: string = "/api/Dashboard";
    private readonly _ioiDetailUrl: string = "/api/ItemOfInterest/ioi/";

    get dashboardUrl() { return this.configurations.baseUrl + this._dashboardUrl; }
    get ioiDetailUrl() { return this.configurations.baseUrl + this._ioiDetailUrl; }


    constructor(http: HttpClient, configurations: ConfigurationService, injector: Injector) {

        super(http, configurations, injector);
    }

    getDashboardEndpoint<T>(): Observable<T> {
        let endpointUrl = this.dashboardUrl;

        return this.http.get<T>(endpointUrl, this.getRequestHeaders())
            .catch(error => {
                return this.handleError(error, () => this.getDashboardEndpoint());
            });
    }
    getIoiDetailEndpoint<T>(id?: number): Observable<T> {
        let endpointUrl = this.ioiDetailUrl + id;
        return this.http.get<T>(endpointUrl, this.getRequestHeaders())
            .catch(error => {
                return this.handleError(error, () => this.getIoiDetailEndpoint(id));
            });
    }


}



