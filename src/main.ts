import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import route from './Route/index.ts';

//将路由挂载到项目中
createApp(App).use(route).mount('#app')
