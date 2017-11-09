//Angular Components
import { Component, OnInit } from '@angular/core';

//App Services
import { HistoriesService } from './../../services/histories.services';

//App Interfaces
import { History } from './../../interfaces/history.interface';

@Component({
    selector: "histories",
    templateUrl: "histories.component.html"
})

export class HistoriesComponent implements OnInit
{
    histories:History[];

    constructor(private historyService:HistoriesService){}

    ngOnInit()
    {
        this.getAllHistory();
    }

    getAllHistory()
    {
        this.historyService.getAllHistories().subscribe((history) =>
        {
            this.histories = history;
        })
    }
}