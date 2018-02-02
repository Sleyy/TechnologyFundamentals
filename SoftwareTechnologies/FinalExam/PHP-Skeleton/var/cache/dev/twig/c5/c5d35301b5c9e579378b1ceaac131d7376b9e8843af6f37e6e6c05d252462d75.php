<?php

/* project/index.html.twig */
class __TwigTemplate_497e553cb8a9876eabbdc24baeff1d92ba0322cc9692f44433c627072334235f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_858d6e2b59caf7c5ec31da55671fb54b54d239d488e86945246d1a1dce432268 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_858d6e2b59caf7c5ec31da55671fb54b54d239d488e86945246d1a1dce432268->enter($__internal_858d6e2b59caf7c5ec31da55671fb54b54d239d488e86945246d1a1dce432268_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/index.html.twig"));

        $__internal_5875f5ec0425fa5bd1e439f69231aa5074109605f75f4992439e9321dd0e22a6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5875f5ec0425fa5bd1e439f69231aa5074109605f75f4992439e9321dd0e22a6->enter($__internal_5875f5ec0425fa5bd1e439f69231aa5074109605f75f4992439e9321dd0e22a6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_858d6e2b59caf7c5ec31da55671fb54b54d239d488e86945246d1a1dce432268->leave($__internal_858d6e2b59caf7c5ec31da55671fb54b54d239d488e86945246d1a1dce432268_prof);

        
        $__internal_5875f5ec0425fa5bd1e439f69231aa5074109605f75f4992439e9321dd0e22a6->leave($__internal_5875f5ec0425fa5bd1e439f69231aa5074109605f75f4992439e9321dd0e22a6_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_8b694f1326892ed9915c95d1f96d451c2f27498d6e2109aaecb7cfbde79e2c29 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8b694f1326892ed9915c95d1f96d451c2f27498d6e2109aaecb7cfbde79e2c29->enter($__internal_8b694f1326892ed9915c95d1f96d451c2f27498d6e2109aaecb7cfbde79e2c29_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_1c955f7f6b439ad88976c2132b00ffd88b7b808cda4e341675c948375f5ca010 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1c955f7f6b439ad88976c2132b00ffd88b7b808cda4e341675c948375f5ca010->enter($__internal_1c955f7f6b439ad88976c2132b00ffd88b7b808cda4e341675c948375f5ca010_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Project</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Project</div>
            <div class=\"budget-label\">Budget</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            ";
        // line 15
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["projects"] ?? $this->getContext($context, "projects")));
        foreach ($context['_seq'] as $context["_key"] => $context["project"]) {
            // line 16
            echo "                <div class=\"project\">
                    <div class=\"project-title\">
                        ";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["project"], "title", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"project-budget\">
                        ";
            // line 21
            echo twig_escape_filter($this->env, $this->getAttribute($context["project"], "budget", array()), "html", null, true);
            echo "
                    </div>
                    <div class=\"project-actions\">
                        <a type=\"button\" href=\"";
            // line 24
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("edit", array("id" => $this->getAttribute($context["project"], "id", array()))), "html", null, true);
            echo "\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"";
            // line 25
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute($context["project"], "id", array()))), "html", null, true);
            echo "\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['project'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 29
        echo "        </div>
    </div>
</div>
";
        
        $__internal_1c955f7f6b439ad88976c2132b00ffd88b7b808cda4e341675c948375f5ca010->leave($__internal_1c955f7f6b439ad88976c2132b00ffd88b7b808cda4e341675c948375f5ca010_prof);

        
        $__internal_8b694f1326892ed9915c95d1f96d451c2f27498d6e2109aaecb7cfbde79e2c29->leave($__internal_8b694f1326892ed9915c95d1f96d451c2f27498d6e2109aaecb7cfbde79e2c29_prof);

    }

    public function getTemplateName()
    {
        return "project/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  96 => 29,  86 => 25,  82 => 24,  76 => 21,  70 => 18,  66 => 16,  62 => 15,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <div class=\"button-holder\">
        <a type=\"button\" href=\"/create\" class=\"log-button\">Create New Project</a>
    </div>
    <div class=\"content\">
        <div class=\"header\">
            <div class=\"project-label\">Project</div>
            <div class=\"budget-label\">Budget</div>
            <div class=\"actions-label\">Actions</div>
        </div>
        <div class=\"main\">
            {% for project in projects %}
                <div class=\"project\">
                    <div class=\"project-title\">
                        {{ project.title }}
                    </div>
                    <div class=\"project-budget\">
                        {{ project.budget }}
                    </div>
                    <div class=\"project-actions\">
                        <a type=\"button\" href=\"{{ path('edit', {id: project.id}) }}\" class=\"edit-button\">Edit</a>
                        <a type=\"button\" href=\"{{ path('delete', {id: project.id}) }}\" class=\"delete-button\">Delete</a>
                    </div>
                </div>
            {% endfor %}
        </div>
    </div>
</div>
{% endblock %}", "project/index.html.twig", "C:\\Projects\\PHP-Skeleton\\app\\Resources\\views\\project\\index.html.twig");
    }
}
