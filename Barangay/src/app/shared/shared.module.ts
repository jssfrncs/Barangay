import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AngularMaterialModule } from './angular-material.module';
import { MatToolbarModule } from '@angular/material/toolbar';
@NgModule({
  declarations: [],
  exports: [
    CommonModule,
    RouterModule,
    AngularMaterialModule,
    MatToolbarModule,
  ],
})
export class SharedModule {}
