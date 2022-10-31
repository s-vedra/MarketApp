import { Directive, ElementRef, HostBinding, HostListener, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appTextFont]'
})
export class TextFontDirective {

  @HostBinding('style.backgroundColor') backgroundColor! : string
  constructor() { }
  @HostListener('mouseover')
  onMouseOver(){
    this.backgroundColor = 'black'
  }
  @HostListener('mouseleave')
  onMouseLeave(){
    this.backgroundColor = '#0275d8'
  }
}
