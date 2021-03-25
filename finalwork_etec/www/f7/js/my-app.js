var app = new Framework7({
  // App root element
  root: '#app',
  // App Name
  name: 'Chat',
  // App id
  id: 'com.myapp.test',
  // Enable swipe panel
  panel: {
    swipe: 'left',
      
  },
  // Add default routes
  routes: [
    {
      path: '/ongs/',
      url: 'ongs.html',
        
    },
      {
      path: '/geo/',
      url: 'gelolocalizacao.html',
    },
      
        {
      path: '/infong/',
      url: 'infong.html',
    },
      
    {
      path: '/campanha/',
      url: 'campanha.html',
    },
      
      {
      path: '/index/',
      url: 'index.html',
        
    },
      
       {
      path: '/chat/',
      url: 'chat.html',
       },
       
      
      
      {
      path: '/fale/',
      url: 'fale.html',
        
    },
 
       {
      path: '/cadastro/',
      url: 'cadastro.html',
        
    },
       {
      path: '/foto/',
      url: 'foto.html',
        
    },
      
  ],
    
     dialog: {
    // set default title for all dialog shortcuts
    title: 'Donation App ',
    // change default "OK" button text
    buttonOk: 'OK!',
  
  },
    
  // ... other parameters
});

var mainView = app.views.create('.view-main');







