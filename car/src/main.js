import Vue from 'vue'
import App from './App.vue'
import VueRouter from "vue-router"
import DeleteCar from "./components/DeleteCar";
import AddCar from "./components/AddCar";
import UpdateCar from "./components/UpdateCar";
import CarList from "./components/CarList";

Vue.config.productionTip = false
Vue.use(VueRouter)
const routes = [
  {path: '/delete', component: DeleteCar},
  {path: '/add', component: AddCar},
  {path: '/update', component: UpdateCar},
  {path: '', component: CarList},
  {path: '/list', component: CarList},
];

const router = new VueRouter({
  mode:'history',
  routes
})

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
