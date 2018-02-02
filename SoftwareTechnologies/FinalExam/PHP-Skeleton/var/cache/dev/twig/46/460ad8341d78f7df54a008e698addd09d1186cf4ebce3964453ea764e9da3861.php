<?php

/* @WebProfiler/Collector/ajax.html.twig */
class __TwigTemplate_1ba2844ce327644c79ce021cb22291f7c7f4345900a886756bff7f8093a09dc7 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/ajax.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_583b754f43f0218cfb4a2a41e1df60a2b9085eba0b2ee8d899dc919580bdd6e8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_583b754f43f0218cfb4a2a41e1df60a2b9085eba0b2ee8d899dc919580bdd6e8->enter($__internal_583b754f43f0218cfb4a2a41e1df60a2b9085eba0b2ee8d899dc919580bdd6e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $__internal_7ff7d0009af824b896e44084e4274bd3fa4cad5c220cb555a4f444ad5f3f684d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7ff7d0009af824b896e44084e4274bd3fa4cad5c220cb555a4f444ad5f3f684d->enter($__internal_7ff7d0009af824b896e44084e4274bd3fa4cad5c220cb555a4f444ad5f3f684d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_583b754f43f0218cfb4a2a41e1df60a2b9085eba0b2ee8d899dc919580bdd6e8->leave($__internal_583b754f43f0218cfb4a2a41e1df60a2b9085eba0b2ee8d899dc919580bdd6e8_prof);

        
        $__internal_7ff7d0009af824b896e44084e4274bd3fa4cad5c220cb555a4f444ad5f3f684d->leave($__internal_7ff7d0009af824b896e44084e4274bd3fa4cad5c220cb555a4f444ad5f3f684d_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_867b53848c86772399bc7adeaf1ba39d287a2bc492cc08b61cd194c82c052ffe = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_867b53848c86772399bc7adeaf1ba39d287a2bc492cc08b61cd194c82c052ffe->enter($__internal_867b53848c86772399bc7adeaf1ba39d287a2bc492cc08b61cd194c82c052ffe_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_e644ae549fc553a7555df97ad6e6e3b51fbfd3a9cb50b717389e4f57fba955b6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e644ae549fc553a7555df97ad6e6e3b51fbfd3a9cb50b717389e4f57fba955b6->enter($__internal_e644ae549fc553a7555df97ad6e6e3b51fbfd3a9cb50b717389e4f57fba955b6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        // line 4
        echo "    ";
        ob_start();
        // line 5
        echo "        ";
        echo twig_include($this->env, $context, "@WebProfiler/Icon/ajax.svg");
        echo "
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    ";
        $context["icon"] = ('' === $tmp = ob_get_clean()) ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 8
        echo "
    ";
        // line 9
        $context["text"] = ('' === $tmp = "        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    ") ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 29
        echo "
    ";
        // line 30
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/toolbar_item.html.twig", array("link" => false));
        echo "
";
        
        $__internal_e644ae549fc553a7555df97ad6e6e3b51fbfd3a9cb50b717389e4f57fba955b6->leave($__internal_e644ae549fc553a7555df97ad6e6e3b51fbfd3a9cb50b717389e4f57fba955b6_prof);

        
        $__internal_867b53848c86772399bc7adeaf1ba39d287a2bc492cc08b61cd194c82c052ffe->leave($__internal_867b53848c86772399bc7adeaf1ba39d287a2bc492cc08b61cd194c82c052ffe_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/ajax.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  85 => 30,  82 => 29,  62 => 9,  59 => 8,  52 => 5,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}
    {% set icon %}
        {{ include('@WebProfiler/Icon/ajax.svg') }}
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    {% endset %}

    {% set text %}
        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    {% endset %}

    {{ include('@WebProfiler/Profiler/toolbar_item.html.twig', { link: false }) }}
{% endblock %}
", "@WebProfiler/Collector/ajax.html.twig", "C:\\Projects\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\ajax.html.twig");
    }
}
