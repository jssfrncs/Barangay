import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SharedModule } from '../../shared/shared.module';

@Component({
  selector: 'app-household-form',
  imports: [SharedModule],
  templateUrl: './household-form.component.html',
  styleUrl: './household-form.component.css',
})
export class HouseholdFormComponent {
  constructor(private fb: FormBuilder) {}
  form: FormGroup = this.fb.group({
    houseHoldNO: ['', Validators.required],
    streetID: [null, Validators.required],
    villageID: [null, Validators.required],
    purokID: [null, Validators.required],
    nearID: [null, Validators.required],
  });
}
