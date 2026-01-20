import { Routes } from '@angular/router';
import { MainComponent } from './layout/main/main.component';
import { NewHouseholdComponent } from './household/new-household/new-household.component';
import { HouseholdComponent } from './household/household/household.component';

export const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children: [
      {
        path: 'household',
        component: HouseholdComponent,
      },
      {
        path: 'household/new',
        component: NewHouseholdComponent,
      },
    ],
  },
];
