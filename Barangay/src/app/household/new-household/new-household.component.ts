import { Component, ViewChild } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { HouseholdFormComponent } from '../household-form/household-form.component';

@Component({
  selector: 'app-new-household',
  imports: [SharedModule, HouseholdFormComponent],
  templateUrl: './new-household.component.html',
  styleUrl: './new-household.component.css',
})
export class NewHouseholdComponent {
  isLoading: boolean = false;
  @ViewChild(HouseholdFormComponent) movieForm: HouseholdFormComponent;
}
