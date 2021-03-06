# tiny-slider 2.0
![version](https://img.shields.io/badge/Version-2.2.4-green.svg)  
Tiny slider for all purposes, inspired by [Owl Carousel](https://owlcarousel2.github.io/OwlCarousel2/).   
[Demos](http://ganlanyuan.github.io/tiny-slider/tests/index.html)   
[Tests](http://ganlanyuan.github.io/tiny-slider/tests/tests.html)  
Can be tested on Firefox 12+, Chrome 15+, Safari 4+, Opera 12.1+, IE8+.  
Note: some features may need a manual test.  

*Previous versions*:
[v1](https://github.com/ganlanyuan/tiny-slider/tree/v1),
[v0](https://github.com/ganlanyuan/tiny-slider/tree/v0)  

## Contents
\+ [What's new](#whats-new)  
\+ [Features](#features)  
\+ [Install](#install)  
\+ [Usage](#usage)  
\+ [Options](#options)  
\+ [Responsive options](#responsive-options)  
\+ [Methods](#methods)  
\+ [Custom Events](#custom-events)  
\+ [Fallback](#fallback)  
\+ [Browser Support](#browser-support)  
\+ [Support](#support)  
\+ [License](#license)  

## What's new
- Using `%` instead of `px` (No more recalculation of each slide width on window resize)
- Using CSS Mediaqueries if supported
- Save browser capbility values to [localStorage](https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage), so they will not be recheck again until browser get upgraded or user clear the localStorage manuelly.
- More options available for `responsive`. (Start from [v2.1.0](https://github.com/ganlanyuan/tiny-slider/releases/tag/v2.1.0), [issue 53](https://github.com/ganlanyuan/tiny-slider/issues/53))
- Insert `controls` and `nav` _before_ slider instead of after ([issue 4](https://github.com/ganlanyuan/tiny-slider/issues/4))
- Move `autoplay` button out of `nav` container. (Start from [v2.1.0](https://github.com/ganlanyuan/tiny-slider/releases/tag/v2.1.0))
- Some selector changes in [`tiny-slider.scss`](https://github.com/ganlanyuan/tiny-slider/blob/master/src/tiny-slider.scss)

*Migrating to v2*
- Update `controls` and / or `nav` styles based on their position changes. 
- Update the [`slider selectors`](https://github.com/ganlanyuan/tiny-slider/blob/master/src/tiny-slider.scss) accordingly if used in your CSS or JS.
- Update styles related to `autoplay` button.  

*[top???](#tiny-slider-20)*  

## Features
- carousel / gallery
- responsive
- fixed width
- vertical slider
- gutter
- edge padding (center)
- loop
- rewind ([pull 10](https://github.com/ganlanyuan/tiny-slider/pull/10))
- slide by
- customize controls / nav
- lazyload
- autoplay
- auto height
- touch support
- mouse drag ([pull 32](https://github.com/ganlanyuan/tiny-slider/pull/32))
- arrow keys
- accessibility for people using keyboard navigation or screen readers ([issue 4](https://github.com/ganlanyuan/tiny-slider/issues/4))
- response to visibility changing ([pull 19](https://github.com/ganlanyuan/tiny-slider/pull/29))
- custom events
- nested slider  

*[top???](#tiny-slider-20)*  

## Install
`bower install tiny-slider` or `npm install tiny-slider`

## Usage
##### 1. Include tiny-slider
via [cdnjs](https://cdnjs.com/libraries/tiny-slider):  
```html
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/tiny-slider/2.2.4/tiny-slider.css">

<!--[if (lt IE 9)]><script src="https://cdnjs.cloudflare.com/ajax/libs/tiny-slider/2.2.4/min/tiny-slider.helper.ie8.js"></script><![endif]-->
<script src="https://cdnjs.cloudflare.com/ajax/libs/tiny-slider/2.2.4/min/tiny-slider.js"></script>

<!-- NOTE: from v2.2.1 tiny-slider.js is no longer required to be in <body> -->
```
Or import it via `webpack` or `rollup`:
```javascript
// yourScript.js
import { tns } from "path/to/src/tiny-slider.module"
```

##### 2. Add markup
```html
<div class="my-slider">
  <div></div>
  <div></div>
  <div></div>
</div>
<!-- or ul.my-slider > li -->
```

##### 3. Call tiny-slider
```html
<script>
  var slider = tns({
    container: '.my-slider',
    items: 3,
    slideBy: 'page',
    autoplay: true
  });
  
  // NOTE: 
  // prior to v2.0.2, options "container", "controlsContainer", "navContainer" and "autoplayButton" still need to be DOM elements.
  // e.g. container: document.querySelector('.my-slider'),
</script>
```
*[top???](#tiny-slider-20)*  

## Options

| Option | Type | Description |
| --- | --- | --- |
| `container` | Node \| String | Default: `document.querySelector('.slider')`. <br> The slider container element or selector. |
| `mode` | `'carousel'` \| `'gallery'` | Default: `'carousel'`. <br> Controls animation behaviour. <br> With `carousel` everything slides to the side, while `gallery` uses fade animations and changes all slides at once. |
| `axis` | `'horizontal'` \| `'vertical'` | Default: `horizontal`. <br> The axis of the slider. |
| `items` | Integer | Default: `1`. <br> Number of slides being displayed. |
| `gutter` | Integer | Default: `0`. <br> Space between slides (in "px"). |
| `edgePadding` | Integer | Default: `0`. <br> Space on the outside (in "px"). |
| `fixedWidth` | Integer \| false | Default: `false`. <br> Controls `width` attribute of the slides. |
| `slideBy` | Integer \| `'page'` | Default: `1`. <br> Number of slides going on one "click". |
| `controls` | Boolean | Default: `true`. <br> Controls the display and functionalities of `controls` components (prev/next buttons). If `true`, display the `controls` and add all functionalities. |
| `controlsText` | (Text \| Markup) Array | Default: `['prev', 'next']`. <br> Text or markup in the prev/next buttons. |
| `controlsContainer` | Node \| String \| `false` | Default: `false`. <br> The container element/selector around the prev/next buttons. <br> `controlsContainer` must have at least 2 child elements. |
| `nav` | Boolean | Default: `true`. <br> Controls the display and functionalities of `nav` components (dots). If `true`, display the `nav` and add all functionalities. |
| `navContainer` | Node \| String \| `false` | Default: `false`. <br> The container element/selector around the dots. <br> `navContainer` must have at least same number of children as the slides. |
| `arrowKeys` | Boolean | Default: `false`. <br> Allows using arrow keys to switch slides. |
| `speed` | Integer | Default: `300`. <br> Speed of the slide animation (in "ms"). |
| `autoplay` | Boolean | Default: `false`. <br> Toggles the automatic change of slides. |
| `autoplayTimeout` | Integer | Default: `5000`. <br> Time between 2 `autoplay` slides change (in "ms"). |
| `autoplayDirection` | `'forward'` \| `'backward'` | Default: `'forward'`. <br> Direction of slide movement (ascending/descending the slide index). |
| `autoplayText` | Array (Text \| Markup) | Default: `['start', 'stop']`. <br> Text or markup in the autoplay start/stop button. |
| `autoplayHoverPause` | Boolean | Default: `false`. <br> Stops sliding on mouseover. |
| `autoplayButton` | Node \| String \| `false` | Default: `false`. <br> The customized autoplay start/stop button or selector. |
| `autoplayButtonOutput` | Boolean | Default: `true`. <br> Output `autoplayButton` markup when `autoplay` is true but a customized `autoplayButton` is not provided. |
| `autoplayResetOnVisibility` | Boolean | Default: `true`. <br> Pauses the sliding when the page is invisiable and resumes it when the page become visiable again. ([Page Visibility API](https://developer.mozilla.org/en-US/docs/Web/API/Page_Visibility_API)) |
| `animateIn` | String | Default: `'tns-fadeIn'`. <br> Name of intro animation `class`. |
| `animateOut` | String | Default: `'tns-fadeOut'`. <br> Name of outro animation `class`. |
| `animateNormal` | String | Default: `'tns-normal'`. <br> Name of default animation `class`. |
| `animateDelay` | Integer \| `false` | Default: `false`. <br> Time between each `gallery` animation (in "ms"). |
| `loop` | Boolean | Default: `true`. <br> Moves to the first slide with the same direction when reaching the last slide. |
| `rewind` | Boolean | Default: `false`. <br> Moves to the first slide with the opposite direction when reaching the last slide. |
| `autoHeight` | Boolean | Default: `false`. <br> Height of slider container changes according to each slide's height. |
| `responsive` | Map: { <br>&emsp;breakpoint: { <br>&emsp;&emsp;key: value<br>&emsp;} <br>} \| `false` | Default: `false`. <br>Breakpoint: Integer.<br>Defines options for different viewport widths (see [Responsive Options](#responsive-options)). <br> |
| `lazyload` | Boolean | Default: `false`. <br> Enables lazyloading images that are currently not viewed, thus saving bandwidth (see [demo](http://ganlanyuan.github.io/tiny-slider/tests/#lazyload_wrapper)). |
| `touch` | Boolean | Default: `true`. <br> Activates input detection for touch devices. |
| `mouseDrag` | Boolean | Default: `false`. <br> Changing slides by dragging them. |
| `nested` | `"inner"` \| `"outer"` \| `false` | Default: `false`. <br> Difine the relationship between nested sliders. (see [demo](http://ganlanyuan.github.io/tiny-slider/tests/#nested_wrapper)) <br>Make sure you run the inner slider first, otherwise the height of the inner slider container will be wrong. |
| `disable` | Boolean | Default: `false`. <br> Disable slider. |
| `onInit` | Function \| `false` | Default: `false`. <br> Callback to be run on initialization. |

*[top???](#tiny-slider-20)*  

## Responsive options
The following options can be redefined in `responsive` field:  
`items`,   
`slideBy`,   
`speed`,   
`autoHeight`,   
`fixedWidth`,   
`edgePadding`,   
`gutter`,   
`controls`,   
`controlsText`,   
`nav`,   
`autoplay`,   
`autoplayHoverPause`,   
`autoplayResetOnVisibility`,   
`autoplayText`,   
`autoplayTimeout`,   
`touch`,   
`mouseDrag`,   
`arrowKeys`,
`disable`.   
NOTE: `fixedWidth` can only be changed to different positive integers. It can't be changed to different data type, 0 or negtive integer.
```javascript
<script>
  var slider = tns({
    container: '.my-slider',
    items: 1,
    responsive: {
      640: {
        edgePadding: 20,
        gutter: 20,
        items: 2
      },
      700: {
        gutter: 30
      },
      900: {
        items: 3
      }
    }
  });
</script>
```
*[top???](#tiny-slider-20)*  

## Methods
There are 2 ways to get slider information, both return `info` Object:   
1. `getInfo` method.   
2. Subscribe to an event.   
```javascript
// info Object
info = {
  container: container, // slider container
  slideItems: slideItems, // slides list
  navContainer: navContainer, // nav container
  navItems: navItems, // dots list
  controlsContainer: controlsContainer, // controls container
  prevButton: prevButton, // previous button
  nextButton: nextButton, // next button
  items: items, // items on a page
  slideBy: slideBy // items slide by
  cloneCount: cloneCount, // cloned slide count
  slideCount: slideCount, // original slide count
  slideCountNew: slideCountNew, // total slide count after initialization
  index: index, // current index
  indexCached: indexCached, // previous index
  navCurrent: navCurrent, // current dot index
  navCurrentCached: navCurrentCached, // previous dot index
  visibleNavIndexes: visibleNavIndexes, // visible nav indexes
  visibleNavIndexesCached: visibleNavIndexesCached,
  event: e || {}, // event object if available
};
```

##### getInfo
```javascript
// get info object
var slider = tns(...);
slider.getInfo();

document.querySelector('.next-button').onclick = function () {
  // get slider info
  var info = slider.getInfo(),
      indexPrev = info.indexCached;
      indexCurrent = info.index;

  // update style based on index
  info.slideItems[indexPrev].classList.remove('active');
  info.slideItems[indexCurrent].classList.add('active');
};
```

##### goTo
```javascript
// go to slides by number or keywords
var slider = tns(...);
slider.goTo(3);
slider.goTo('prev');
slider.goTo('next');
slider.goTo('first');
slider.goTo('last');

document.querySelector('.goto-button').onclick = function () {
  slider.goTo(3);
};
```

##### destroy
```javascript
var slider = tns(...);
slider.destroy();
```
## Custom Events
Available events include: `indexChanged`, `transitionStart`, `transitionEnd`, `touchStart`, `touchMove` and `touchEnd`.
```javascript
var slider = tns(...);

var customizedFunction = function (info) {
  // direct access to info object
  console.log(info.event.type, info.container.id);
}

// bind function to event
slider.events.on('transitionEnd', customizedFunction);

// remove function binding
slider.events.off('transitionEnd', customizedFunction);
```
*[top???](#tiny-slider-20)*  

#### Fallback
```css
.no-js .your-slider { overflow-x: auto; }
.no-js .your-slider > div { float: none; }
```

## Browser Support
Firefox 8+ ???  
Chrome 15+ ???  
Safari 4+ ???  
Opera 12.1+ ???   
IE 8+ ???  
Should be working on _Chrome 4-14_ as well, but I couldn't test it.  

## Support
[Browserstack](https://www.browserstack.com/)  
[Cdnjs](https://cdnjs.com/)  

## License
This project is available under the [MIT](https://opensource.org/licenses/mit-license.php) license.  
