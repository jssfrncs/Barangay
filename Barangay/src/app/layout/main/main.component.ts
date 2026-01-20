import { Component } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'app-main',
  imports: [SharedModule, HeaderComponent],
  templateUrl: './main.component.html',
  styleUrl: './main.component.css',
})
export class MainComponent {
  fragments = [
    { label: 'Dashboard', route: '', icon: 'dashboard_2' },
    { label: 'Residents', route: 'resident', icon: 'person_4' },
    { label: 'HouseHold', route: 'household', icon: 'house' },
    { label: 'Document Issuance', route: 'household', icon: 'edit_document' },
    { label: 'Financial', route: 'household', icon: 'account_balance' },
    { label: 'Asset Management', route: 'household', icon: 'inventory_2' },
    { label: 'Peace and Order', route: 'household', icon: 'cases' },
  ];
  activeLink: string | null = null;
}
