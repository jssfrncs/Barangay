import { Component } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'app-main',
  imports: [SharedModule, HeaderComponent],
  templateUrl: './main.component.html',
  styleUrl: './main.component.css',
})
export class MainComponent {}
