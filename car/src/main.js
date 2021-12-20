import Vue from 'vue'
import App from './App.vue'
import VueRouter from "vue-router"
import DeleteCar from "./components/DeleteCar";
import AddCar from "./components/AddCar";
import UpdateCar from "./components/UpdateCar";
import styles from "../uikit/css/uikit.min.css"

Vue.config.productionTip = false
Vue.use(VueRouter)
const routes = [
  {path: '/delete', component: DeleteCar},
  {path: '/add', component: AddCar},
  {path: '/update', component: UpdateCar}
];

const router = new VueRouter({
  mode:'history',
  routes
})

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
